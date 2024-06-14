﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BrutalAPI
{
    public class Ability
    {
        public AbilitySO ability;

        #region ABILITY PROPERTIES
        public string ID
        {
            set
            {
                ability.name = $"{value}_AB";
            }
        }
        public string Name
        {
            set
            {
                ability._abilityName = value;
            }
        }
        public string Description
        {
            set
            {
                ability._description = value;
            }
        }
        public Sprite AbilitySprite
        {
            set
            {
                ability.abilitySprite = value;
            }
        }
        public PrioritySO Priority
        {
            set
            {
                ability.priority = value;
            }
        }
        public AttackVisualsSO Visuals
        {
            set
            {
                ability.visuals = value;
            }
        }
        public BaseCombatTargettingSO AnimationTarget
        {
            set
            {
                ability.animationTarget = value;
            }
        }
        public UnitStoreData_BasicSO UnitStoreData
        {
            set
            {
                ability.specialStoredData = value;
            }
        }
        public List<IntentTargetInfo> EffectIntents
        {
            get
            {
                return ability.intents;
            }
            set
            {
                ability.intents = value;
            }
        }
        public EffectInfo[] Effects
        {
            get
            {
                return ability.effects;
            }
            set
            {
                ability.effects = value;
            }
        }
        public ManaColorSO[] Cost { get; set; }
        public RaritySO Rarity { get; set; }
        #endregion

        public void AddIntentsToTarget(BaseCombatTargettingSO targets, string[] intents)
        {
            IntentTargetInfo info = new IntentTargetInfo();
            info.targets = targets;
            info.intents = intents;
            ability.intents.Add(info);
        }

        public Ability(string id)
        {
            ability = ScriptableObject.CreateInstance<AbilitySO>();
            ability.name = id;
            ability.effects = new EffectInfo[0];
            ability.intents = new List<IntentTargetInfo>();
            //Basic Priority
            ability.priority = LoadedDBsHandler.MiscDB.DefaultPriority;
            Rarity = LoadedDBsHandler.MiscDB.DefaultRarity;
            Cost = [];
        }
        public Ability(string name, string id)
        {
            ability = ScriptableObject.CreateInstance<AbilitySO>();
            ability.name = id;
            ability._abilityName = name;
            ability.effects = new EffectInfo[0];
            ability.intents = new List<IntentTargetInfo>();
            //Basic Priority
            ability.priority = LoadedDBsHandler.MiscDB.DefaultPriority;
            Rarity = LoadedDBsHandler.MiscDB.DefaultRarity;
            Cost = [];
        }
        /// <summary>
        /// Use this one to Clone an existing AbilitySO!
        /// </summary>
        /// <param name="abilityToClone"></param>
        /// <param name="abilityID"></param>
        public Ability(AbilitySO abilityToClone, string abilityID, ManaColorSO[] cost = null, RaritySO rarity = null)
        {
            ability = abilityToClone.Clone();
            ability.name = abilityID;
            Cost = (cost == null) ? [] :cost;
            Rarity = (rarity == null) ? LoadedDBsHandler.MiscDB.DefaultRarity : rarity;
        }

        public CharacterAbility GenerateCharacterAbility(bool addToDB = false)
        {
            if (addToDB)
                LoadedDBsHandler.AbilityDB.AddNewCharacterAbility(ability.name, ability);

            CharacterAbility ab = new CharacterAbility();
            ab.ability = ability;
            ab.cost = Cost;
            return ab;
        }
        public EnemyAbilityInfo GenerateEnemyAbility(bool addToDB = false)
        {
            if (addToDB)
                LoadedDBsHandler.AbilityDB.AddNewEnemyAbility(ability.name, ability);
            
            EnemyAbilityInfo ab = new EnemyAbilityInfo();
            ab.ability = ability;
            ab.rarity = Rarity;
            return ab;
        }


    }
}
