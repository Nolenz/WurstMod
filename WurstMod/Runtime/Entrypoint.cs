﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;
using WurstMod.MappingComponents.TakeAndHold;
using WurstMod.Runtime.ScenePatchers;

namespace WurstMod.Runtime
{
    [BepInPlugin("com.koba.plugins.wurstmod", "WurstMod", "2.0.0.0")]
    public class Entrypoint : BaseUnityPlugin
    {
        public static BaseUnityPlugin self;

        void Awake()
        {
            self = this;
            LegacySupport.Init();
            RegisterListeners();
            InitDetours();
            InitAppDomain();
            InitConfig();
        }

        void RegisterListeners()
        {
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        }

        void InitDetours()
        {
            Patches.Patch();
        }

        private static readonly Dictionary<string, Assembly> Assemblies = new Dictionary<string, Assembly>();

        void InitAppDomain()
        {
            AppDomain.CurrentDomain.AssemblyLoad += (sender, e) => { Assemblies[e.LoadedAssembly.FullName] = e.LoadedAssembly; };
            AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
            {
                Assemblies.TryGetValue(e.Name, out var assembly);
                return assembly;
            };
        }

        public static ConfigEntry<string> configQuickload;
        void InitConfig()
        {
            configQuickload = Config.Bind("Debug", "QuickloadPath", "", "Set this to a folder containing the scene you would like to load as soon as H3VR boots. This is good for quickly testing scenes you are developing.");
        }

        private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
        {
            TNH_LevelSelector.SetupLevelSelector(scene);
            Generic_LevelPopulator.SetupLevelPopulator(scene);
            
            StartCoroutine(Loader.OnSceneLoad(scene));
            DebugQuickloader.Quickload(scene); // Must occur after regular loader.
        }
    }
}