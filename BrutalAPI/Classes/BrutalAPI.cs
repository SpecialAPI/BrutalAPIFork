﻿using BepInEx;
using System.IO;
using System.Xml;
using UnityEngine;

namespace BrutalAPI
{
    [BepInPlugin("BrutalOrchestra.BrutalAPI", "BrutalAPI", "0.1.5")]
    public class BrutalAPI : BaseUnityPlugin
    {
        public static char openDebugConsoleKey = '*';
        public DebugController m_DebugController;


        public void Awake()
        {
            /*
            LoadedDBsHandler.UnlockablesDB.TryGetFinalBossUnlockCheck(BossTypeIDs.OsmanSinnoks.ToString(), out FinalBossCharUnlockCheck check);
            check.entityIDUnlocks.Add
                */

            LoadConfig();


            m_DebugController = new GameObject("DebugController").AddComponent<DebugController>();

            Logger.LogInfo("BrutalAPI loaded successfully!");
        }

        void LoadConfig()
        {
            if (!Directory.Exists(Paths.BepInExRootPath + "/plugins/brutalapi/") || !File.Exists(Paths.BepInExRootPath + "/plugins/brutalapi/brutalapi.config"))
            {
                Directory.CreateDirectory(Paths.BepInExRootPath + "/plugins/brutalapi/");
                StreamWriter streamWriter = File.CreateText(Paths.BepInExRootPath + "/plugins/brutalapi/brutalapi.config");
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml("<config openDebugConsoleKey='*'> </config>");
                xmlDocument.Save(streamWriter);
                streamWriter.Close();
            }

            if (File.Exists(Paths.BepInExRootPath + "/plugins/brutalapi/brutalapi.config"))
            {
                FileStream fileStream = File.Open(Paths.BepInExRootPath + "/plugins/brutalapi/brutalapi.config", FileMode.Open);
                XmlDocument xmlDocument2 = new XmlDocument();
                xmlDocument2.Load(fileStream);
                try
                {
                    openDebugConsoleKey = char.Parse(xmlDocument2.GetElementsByTagName("config")[0].Attributes["openDebugConsoleKey"].Value);
                }
                catch
                {
                    Debug.LogError("Config error! Please check your config file in BepInEx/plugins/brutalapi/brutalapi.config");
                }

                fileStream.Close();
            }
        }

        void Example()
        {


            Character myCharacter = new Character("Bronzo", "Bronzo_CH");


        }
    }
}
