﻿//Copyright © 2019 Procedural Worlds Pty Limited. All Rights Reserved.
using UnityEngine;

namespace AmbientSkies
{
    public class AmbientSkiesConsts : MonoBehaviour
    {
        public enum RenderPipelineSettings { BuiltIn, HighDefinition, Universal }

        public enum HighDefinitionQualitySetting { Custom, MobileAndAndriod, VR, Desktop, HighEndDesktop, Cinematic }

        public enum EnvironementSkyUpdateMode { OnChanged, OnDemand, Realtime }

        public enum VolumeSkyType { Gradient, HDRISky, ProceduralSky }

        public enum VolumeFogType { None, Exponential, ExponentialSquared, Linear, Volumetric }
        
        public enum ShadowCascade { CascadeCount1, CascadeCount2, CascadeCount3, CascadeCount4 }

        public enum HDShadowQuality { Resolution64, Resolution128, Resolution256, Resolution512, Resolution1024, Resolution2048, Resolution4096, Resolution8192, Resolution16384 }

        public enum AmbientMode { Color, Gradient, Skybox }

        public enum VSyncMode { DontSync, EveryVBlank, EverySecondVBlank }

        public enum AntiAliasingMode { None, FXAA, SMAA, TAA, MSAA }

        public enum HDRMode { On, Off }

        public enum SkyType { HDRISky, ProceduralSky }

        public enum PlatformTarget { DesktopAndConsole, MobileAndVR }

        public enum DepthOfFieldMode { AutoFocus, Manual }

        public enum DOFQuality { NORMAL, HIGH }

        public enum DOFTrackingType { FixedOffset, LeftMouseClick, RightMouseClick, FollowScreen, FollowTarget }

        public enum SystemTypes { AmbientHDRISkies, AmbientProceduralSkies, AmbientGradientSkies, DefaultProcedural, ThirdParty }

        public enum TimeOfDayController { Realtime, AmbientSkies, WorldManagerAPI, ThirdParty }

        public enum CurrentSeason { Spring, Summer, AutumnFall, Winter }

        public enum HemisphereOrigin { Northern, Southern }

        public enum DisableAndEnable { Enable, Disable }

        public enum LightmapperMode { Enlighten, ProgressiveCPU, ProgressiveGPU }

        public enum AutoConfigureType { Terrain, Camera, Manual }

        public enum ReflectionProbeSpawnType { AutomaticallyGenerated, ManualPlacement }

        public enum LightProbeSpawnType { AutomaticallyGenerated, MinDefaultHeight, ManualPlacement }

        public enum ReflectionProbeResolution { Resolution16, Resolution32, Resolution64, Resolution128, Resolution256, Resolution512, Resolution1024, Resolution2048 }

        //public enum EnvironmentLightingEditMode { Exterior, Interior }
        public enum EnvironmentLightingEditMode { Interior }

        public enum LightTypeMode { Static, FlickeringLight, ToggleLight }

        public enum URPTonemappingMode { None, Neutral, ACES }

        public enum URPDepthOfFieldMode { Off, Gaussian, Bokeh }

        public enum URPFilmGrainType { Thin1, Thin2, Medium1, Medium2, Medium3, Medium4, Medium5, Medium6, Large01, Large02, Custom }

        public enum URPMotionBlurQuality { Low, Medium, High }

        public enum HDRPPostProcessingQuality { Custom, Low, Medium, High }

        public enum HDRPBloomResolution { Half, Quarter }

        public enum HDRPIntensityMode { Exposure, Multiplier }

        public enum HDRPAmbientMode { Static, Dynamic }

        public enum HDRPVisualQuality { Low, Medium, High }

        /// <summary>
        /// Prefs used to do a one check to see if you want news to be enabled
        /// </summary>
        public const string ENABLE_NEWS_EDITOR_PREFS = "ENABLE_NEWS_EDITOR_PREFS";
        /// <summary>
        /// Prefs used to enable or disable news
        /// </summary>
        public const string PW_SHOW_NEWS = "PWShowNews";
    }
}