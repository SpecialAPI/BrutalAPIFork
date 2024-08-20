﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;

namespace BrutalAPI
{
    public class OverworldRooms
    {
        public static void Prepare_NPC_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            NPCRoomHandler handler = asset.AddComponent<NPCRoomHandler>();
            NPC_RoomHandlerModData data = asset.GetComponent<NPC_RoomHandlerModData>();
            handler._requiresToTalk = data.m_RequiresToTalk;
            handler._dialogueMusic = data.m_dialogueMusicEvent;

            handler._npcSelectable = GetRoomItemComponent(handler, data.m_NpcSelectable);
            handler._extraSelectable = GetRoomItemComponent(handler, data.m_ExtraSelectable);

            Misc.Prepare_LocalizedImages(asset);

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_Shop_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            ShopRoomHandler handler = asset.AddComponent<ShopRoomHandler>();
            Shop_RoomHandlerModData data = asset.GetComponent<Shop_RoomHandlerModData>();

            handler._shopSelectable = GetRoomItemComponent(handler, data.m_ShopSelectable) as BasicRoomItem;

            Misc.Prepare_LocalizedImages(asset);

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_Fools_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            FoolsRoomHandler handler = asset.AddComponent<FoolsRoomHandler>();
            Fools_RoomHandlerModData data = asset.GetComponent<Fools_RoomHandlerModData>();

            handler._foolRenderers = data.m_FoolRenderers;
            handler._foolsSelectable = GetRoomItemComponent(handler, data.m_FoolsSelectable) as BasicRoomItem;

            Misc.Prepare_LocalizedImages(asset);

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_Treasure_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            PrizeRoomHandler handler = asset.AddComponent<PrizeRoomHandler>();
            Treasure_RoomHandlerModData data = asset.GetComponent<Treasure_RoomHandlerModData>();

            handler._prizeSelectable = GetRoomItemComponent(handler, data.m_TreasureSelectable) as AnimatedRoomItem;

            Misc.Prepare_LocalizedImages(asset);

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_MoneyChest_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            MoneyChestRoomHandler handler = asset.AddComponent<MoneyChestRoomHandler>();
            MoneyChest_RoomHandlerModData data = asset.GetComponent<MoneyChest_RoomHandlerModData>();

            handler._moneyChestSelectable = GetRoomItemComponent(handler, data.m_MoneyChestSelectable) as AnimatedRoomItem;

            Misc.Prepare_LocalizedImages(asset);

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_Enemy_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            EnemyRoomHandler handler = asset.AddComponent<EnemyRoomHandler>();
            Enemy_RoomHandlerModData data = asset.GetComponent<Enemy_RoomHandlerModData>();
            handler._enemyGang = data.m_EnemyGang;
            handler._corpseGang = data.m_CorpseGang;

            handler._enemyRenderers = data.m_EnemyRenderers;
            handler._corpseRenderers = data.m_CorpseRenderers;

            handler._enemySelectables = new BasicRoomItem[data.m_EnemySelectables.Length];
            
            for (int i = 0; i < handler._enemySelectables.Length; i++)
                handler._enemySelectables[i] = GetRoomItemComponent(handler, data.m_EnemySelectables[i]) as BasicRoomItem;

            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        public static void Prepare_Boss_RoomPrefab(string prefabBundlePath, string roomID, AssetBundle fileBundle)
        {
            GameObject asset = fileBundle.LoadAsset<GameObject>(prefabBundlePath);
            BossRoomHandler handler = asset.AddComponent<BossRoomHandler>();
            Boss_RoomHandlerModData data = asset.GetComponent<Boss_RoomHandlerModData>();
            handler._bossPortalHolder = data.m_BossPortalHolder;
            handler._zonePortalHolder = data.m_ZonePortalHolder;

            handler._bossPortalRenderer = data.m_BossPortalRenderer;
            handler._zonePortalRenderer = data.m_ZonePortalRenderer;

            handler._bossPortalSelectable = GetRoomItemComponent(handler, data.m_BossPortalSelectable) as BasicRoomItem;
            handler._zonePortalSelectable = GetRoomItemComponent(handler, data.m_ZonePortalSelectable) as BasicRoomItem;
            handler._extraSelectable = GetRoomItemComponent(handler, data.m_ExtraSelectable);


            LoadedAssetsHandler.AddExternalOWRoom(roomID, handler);
        }

        static BaseRoomItem GetRoomItemComponent(BaseRoomHandler handler, BaseRoomItemModData data)
        {
            if (data == null)
                return null;

            switch (data.RoomItemType)
            {
                case "Basic":
                    BasicRoomItem basic_item = data.gameObject.AddComponent<BasicRoomItem>();
                    basic_item.FillWithModData(data as Basic_RoomItemModData);
                    return basic_item;
                case "Animated":
                    AnimatedRoomItem anim_item = data.gameObject.AddComponent<AnimatedRoomItem>();
                    anim_item.FillWithModData(data as Animated_RoomItemModData);
                    return anim_item;
                case "MandatoryNPC":
                    MandatoryNPCRoomItem mand_item = data.gameObject.AddComponent<MandatoryNPCRoomItem>();
                    mand_item.FillWithModData(handler as NPCRoomHandler, data as MandatoryNPC_RoomItemModData);
                    return mand_item;
                case "CustomDialogue":
                    CustomDialogRoomItem dial_item = data.gameObject.AddComponent<CustomDialogRoomItem>();
                    dial_item.FillWithModData(data as CustomDialogue_RoomItemModData);
                    return dial_item;
                case "CustomDialogueByQuest":
                    CustomDialogByQuestRoomItem diqu_item = data.gameObject.AddComponent<CustomDialogByQuestRoomItem>();
                    diqu_item.FillWithModData(data as CustomDialogueByQuest_RoomItemModData);
                    return diqu_item;
            }

            return null;
        }

    }
}
