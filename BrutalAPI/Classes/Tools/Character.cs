﻿using System.Collections.Generic;
using UnityEngine;

namespace BrutalAPI
{
    /*
    CHARACTERSO
    +id
    +name
    +entity
    +health
    +unit types
    +usesBasic
    BasicAbility
    +usesAll
    -RankedData
        +int health
        abilities[]
    Passives
    -Animator
    +FrontSprite
    +BackSprite
    +OWSprites
    -ExtraSpriteSystem
    +movesOnOW
    +damageSound
    +deathSound
    +dxSound
    +Ach - Boss[]
    SPEAKER DATA NAME

    ZONE
    ShowOnFOOLS

    PORTALS
    Sign ID
    Sign icon 
    Sign Color

    ACHS
    Boss Unlocks

    SELECTABLECHARACTER
    id
    portrait
    noPortrait
    trackData
    isSecret
    ignoreRandomSelection
     */
    public class Character
    {
        public CharacterSO character;
        public SelectableCharacterData menuCharacter;
        public List<int> ignoredSupport;
        public List<int> ignoredDPS;

        #region CHARACTER PROPERTIES
        public string ID_CH
        {
            set
            {
                character.name = value;
            }
        }
        public string EntityID
        {
            set
            {
                character.entityID = value;
            }
        }
        public string Name
        {
            set
            {
                character._characterName = value;
            }
        }
        public ManaColorSO HealthColor
        {
            set
            {
                character.healthColor = value;
            }
        }
        public List<string> UnitTypes
        {
            set
            {
                character.unitTypes = value;
            }
        }
        public bool UsesBasicAbility
        {
            set
            {
                character.usesBasicAbility = value;
            }
        }
        public Ability BasicAbility
        {
            set
            {
                character.basicCharAbility = value.GenerateCharacterAbility();
            }
        }

        public bool UsesAllAbilities
        {
            set
            {
                character.usesAllAbilities = value;
            }
        }
        public bool MovesOnOverworld
        {
            set
            {
                character.movesOnOverworld = value;
            }
        }
        public RuntimeAnimatorController Animator
        {
            set
            {
                character.characterAnimator = value;
            }
        }
        public Sprite FrontSprite
        {
            set
            {
                character.characterSprite = value;
            }
        }
        public Sprite BackSprite
        {
            set
            {
                character.characterBackSprite = value;
            }
        }
        public Sprite OverworldSprite
        {
            set
            {
                character.characterOWSprite = value;
            }
        }
        public ExtraCharacterCombatSpritesSO ExtraSprites
        {
            set
            {
                character.extraCombatSprites = value;
            }
        }
        public string DamageSound
        {
            set
            {
                character.damageSound = value;
            }
        }
        public string DeathSound
        {
            set
            {
                character.deathSound = value;
            }
        }
        public string DialogueSound
        {
            set
            {
                character.dxSound = value;
            }
        }

        #endregion

        #region SELECTION CHAR PROPERTIES
        public void GenerateMenuCharacter(Sprite unlocked, Sprite locked)
        {
            menuCharacter = new SelectableCharacterData(character.name, unlocked, locked);
        }
        public UnlockTrack_Data MenuCharacterTrackData
        {
            set
            {
                menuCharacter._trackData = value;
            }
        }
        public bool MenuCharacterIsSecret
        {
            set
            {
                menuCharacter._isSecret = value;
            }
        }
        public bool MenuCharacterIgnoreRandom
        {
            set
            {
                menuCharacter._ignoreRandomSelection = value;
            }
        }
        public List<int> IgnoredAbilitiesForSupportBuilds
        {
            set
            {
                ignoredSupport = value;
            }
        }
        public List<int> IgnoredAbilitiesForDPSBuilds
        {
            set
            {
                ignoredDPS = value;
            }
        }
        public void SetMenuCharacterAsFullSupport()
        {
            ignoredSupport = new List<int>();  
        }
        public void SetMenuCharacterAsFullDPS()
        {
            ignoredDPS = new List<int>();
        }
        #endregion

        public Character(string displayName, string id_CH)
        {
            character = ScriptableObject.CreateInstance<CharacterSO>();
            ID_CH = id_CH;
            EntityID = id_CH;
            Name = displayName;
            menuCharacter = null;
            ignoredSupport = null;
            ignoredDPS = null;
            //Basic Slap
            character.basicCharAbility = LoadedDBsHandler.AbilityDB.SlapAbility;
            //Initialize Lists here?
            character.m_BossAchData = new List<CharFinalBossAchData>();
            character.passiveAbilities = new List<BasePassiveAbilitySO>();
            character.rankedData = new List<CharacterRankedData>();
        }

        public void SetBasicAbility(CharacterAbility ab)
        {
            character.basicCharAbility = ab;
        }
        public void AddFinalBossAchievementData(string bossID, string achievementID)
        {
            character.m_BossAchData.Add(new CharFinalBossAchData(bossID, achievementID));
        }
        public void AddLevelData(int health, Ability[] abilities)
        {
            CharacterAbility[] charaAbs = new CharacterAbility[abilities.Length];
            for (int i = 0; i < charaAbs.Length; i++)
                charaAbs[i] = abilities[i].GenerateCharacterAbility(); 
            
            character.rankedData.Add(new CharacterRankedData(health, charaAbs));
        }
        public void AddLevelData(int health, CharacterAbility[] abilities)
        {
            character.rankedData.Add(new CharacterRankedData(health, abilities));
        }
        public void AddPassive(BasePassiveAbilitySO passive)
        {
            character.passiveAbilities.Add(passive);
        }
        public void AddPassives(BasePassiveAbilitySO[] passives)
        {
            character.passiveAbilities.AddRange(passives);
        }

        public void AddCharacter(bool unlockCharacter = false, bool omitOnFoolsBoard = false)
        {
            LoadedDBsHandler.CharacterDB.AddNewCharacter(character.name, character, menuCharacter, ignoredSupport, ignoredDPS);
            if (unlockCharacter)
                LoadedDBsHandler.ModdingDB.AddUnlockedCharacter(character.name);
            if (omitOnFoolsBoard)
                LoadedDBsHandler.MiscDB.AddOmittedFoolToZones(character.name);
        }
    }
}
