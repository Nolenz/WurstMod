﻿using UnityEngine;

namespace WurstMod.MappingComponents.Generic
{
    public class PMat : ComponentProxy
    {
        private readonly string[] DefResourcePaths = new string[]
        {
            "PMat_Acrylic",
            "PMat_Air",
            "PMat_Aluminum",
            "PMat_Asphalt",
            "PMat_Basalt",
            "PMat_BotArmor",
            "PMat_BotArmorLight",
            "PMat_BotMeat",
            "PMat_Brass",
            "PMat_Brick",
            "PMat_BulletPopLarge",
            "PMat_BulletPopNormal",
            "PMat_CandyCane",
            "PMat_Carbon",
            "PMat_Cardboard",
            "PMat_Cement",
            "PMat_ClayPigeon",
            "PMat_Cloth",
            "PMat_Concrete",
            "PMat_Copper",
            "PMat_Default",
            "PMat_Dirt",
            "PMat_Flesh",
            "PMat_Glass",
            "PMat_Granite",
            "PMat_Ice",
            "PMat_Iron",
            "PMat_Lead",
            "PMat_Maeblon",
            "PMat_Marble",
            "PMat_NanoFill",
            "PMat_Osmium",
            "PMat_Plaster",
            "PMat_Plastic",
            "PMat_Pumpkin",
            "PMat_PVC",
            "PMat_RotMeat",
            "PMat_Rubber",
            "PMat_Sand",
            "PMat_SodaCanFull",
            "PMat_Steel",
            "PMat_SteelSword",
            "PMat_Styrofoam",
            "PMat_Tantalum",
            "PMat_Titanium",
            "PMat_Tungsten",
            "PMat_Vanadium",
            "PMat_Water",
            "PMat_Wood",
            "NONE"
        };
        public string GetDef(int idx) { return DefResourcePaths[idx]; }

        public enum Def
        {
            Acrylic,
            Air,
            Aluminum,
            Asphalt,
            Basalt,
            BotArmor,
            BotArmorLight,
            BotMeat,
            Brass,
            Brick,
            BulletPopLarge,
            BulletPopNormal,
            CandyCane,
            Carbon,
            Cardboard,
            Cement,
            ClayPigeon,
            Cloth,
            Concrete,
            Copper,
            Default,
            Dirt,
            Flesh,
            Glass,
            Granite,
            Ice,
            Iron,
            Lead,
            Maeblon,
            Marble,
            NanoFill,
            Osmium,
            Plaster,
            Plastic,
            Pumpkin,
            PVC,
            RotMeat,
            Rubber,
            Sand,
            SodaCanFull,
            Steel,
            SteelSword,
            Styrofoam,
            Tantalum,
            Titanium,
            Tungsten,
            Vanadium,
            Water,
            Wood,
            None
        }




        private readonly string[] MatDefResourcePaths = new string[]
        {
            "agents/GasMask",
            "agents/HeavyArmor_Metal",
            "agents/HeavyFabric",
            "agents/LightArmor_Kevlar",
            "agents/Meat",
            "agents/MediumArmor_Metal",
            "agents/MediumArmor_Padded",
            "agents/RotMeat",
            "heldobjects/Testing_MEat",
            "heldobjects/Testing_Soft",
            "nature/ground/Ground_Dirt",
            "nature/ground/Ground_Grass",
            "nature/ground/Ground_Sand",
            "nature/ground/Ground_Water",
            "nature/props/Hedge",
            "nature/props/Rock_Large",
            "nature/props/Rock_Small",
            "props/Claypot",
            "props/PlasticTableTop",
            "props/Tires",
            "props/WaterMelon",
            "props/melee/Melee_Metal",
            "props/melee/Melee_Polymer",
            "props/melee/Melee_Wood",
            "structural/armor/Armor_Solid",
            "structural/armor/Armor_Thick",
            "structural/armor/Armor_Thin",
            "structural/barriers/ConcreteBarrier",
            "structural/barriers/Sandbag",
            "structural/barriers/Water",
            "structural/floors/Floor_CarpetOverConcrete",
            "structural/floors/Floor_CarpetOverWood",
            "structural/floors/Floor_Concrete",
            "structural/floors/Floor_Metal",
            "structural/floors/Floor_MetalGrating",
            "structural/floors/Floor_TileOverConcrete",
            "structural/floors/Floor_TileOverConcreteSolid",
            "structural/floors/Floor_TileOverWood",
            "structural/floors/Floor_Wood",
            "structural/metal/Metal_Plate",
            "structural/metal/Metal_Sheet",
            "structural/metal/Metal_Strut",
            "structural/solid/_Impenetrable",
            "structural/solid/Solid_Armor",
            "structural/solid/Solid_Concrete",
            "structural/solid/Solid_Metal",
            "structural/walls/Wall_Brick",
            "structural/walls/Wall_DryWall",
            "structural/walls/Wall_GlassBrick",
            "structural/walls/Wall_GlassWindow",
            "structural/walls/Wall_SheetMetal",
            "structural/walls/Wall_WoodSolid",
            "structural/walls/Wall_WoodThick",
            "structural/walls/Wall_WoodThin",
            "thin/Paper"
        };
        public string GetMatDef(int idx) { return MatDefResourcePaths[idx]; }

        public enum MatDef
        {
            GasMask,
            HeavyArmor_Metal,
            HeavyFabric,
            LightArmor_Kevlar,
            Meat,
            MediumArmor_Metal,
            MediumArmor_Padded,
            RotMeat,
            Testing_MEat,
            Testing_Soft,
            Ground_Dirt,
            Ground_Grass,
            Ground_Sand,
            Ground_Water,
            Hedge,
            Rock_Large,
            Rock_Small,
            Claypot,
            PlasticTableTop,
            Tires,
            WaterMelon,
            Melee_Metal,
            Melee_Polymer,
            Melee_Wood,
            Armor_Solid,
            Armor_Thick,
            Armor_Thin,
            ConcreteBarrier,
            Sandbag,
            Water,
            Floor_CarpetOverConcrete,
            Floor_CarpetOverWood,
            Floor_Concrete,
            Floor_Metal,
            Floor_MetalGrating,
            Floor_TileOverConcrete,
            Floor_TileOverConcreteSolid,
            Floor_TileOverWood,
            Floor_Wood,
            Metal_Plate,
            Metal_Sheet,
            Metal_Strut,
            _Impenetrable,
            Solid_Armor,
            Solid_Concrete,
            Solid_Metal,
            Wall_Brick,
            Wall_DryWall,
            Wall_GlassBrick,
            Wall_GlassWindow,
            Wall_SheetMetal,
            Wall_WoodSolid,
            Wall_WoodThick,
            Wall_WoodThin,
            Paper
        }


        [Tooltip("Not all static colliders (anything a bullet might hit) have a def. Is this for penetrative properties? Legacy?")]
        public Def def;
        [Tooltip("It seems like all static colliders (anything a bullet might hit) have a matDef.")]
        public MatDef matDef;


        public override void InitializeComponent()
        {
            FistVR.PMat real = gameObject.AddComponent<FistVR.PMat>();

            if (def == Def.None) real.Def = null;
            else real.Def = Resources.Load<FistVR.PMaterialDefinition>("pmaterialdefinitions/" + GetDef((int)def));

            real.MatDef = Resources.Load<FistVR.MatDef>("matdefs/" + GetMatDef((int)matDef));

            Destroy(this);
        }
    }
}
