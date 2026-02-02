using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BrutalAPI
{
    static public class Passives
    {
        #region In-Game Passive Gets
        static public BasePassiveAbilitySO Abomination1 => LoadedAssetsHandler.GetPassive("Abomination_1_PA");
        static public BasePassiveAbilitySO Absorb => LoadedAssetsHandler.GetPassive("Absorb_PA");
        static public BasePassiveAbilitySO Anointed1 => LoadedAssetsHandler.GetPassive("Anointed_1_PA");
        static public BasePassiveAbilitySO Anointed2 => LoadedAssetsHandler.GetPassive("Anointed_2_PA");
        static public BasePassiveAbilitySO Anchored => LoadedAssetsHandler.GetPassive("Anchored_PA");
        static public BasePassiveAbilitySO Bile => LoadedAssetsHandler.GetPassive("Bile_PA");
        static public BasePassiveAbilitySO BoneSpurs1 => LoadedAssetsHandler.GetPassive("BoneSpurs_1_PA");
        static public BasePassiveAbilitySO BoneSpurs2 => LoadedAssetsHandler.GetPassive("BoneSpurs_2_PA");
        static public BasePassiveAbilitySO BoneSpurs3 => LoadedAssetsHandler.GetPassive("BoneSpurs_3_PA");
        static public BasePassiveAbilitySO BronzosBlessing => LoadedAssetsHandler.GetPassive("BronzosBlessing_PA");
        static public BasePassiveAbilitySO Cashout => LoadedAssetsHandler.GetPassive("Cashout_PA");
        static public BasePassiveAbilitySO Catalyst => LoadedAssetsHandler.GetPassive("Catalyst_PA");
        static public BasePassiveAbilitySO Confusion => LoadedAssetsHandler.GetPassive("Confusion_PA");
        static public BasePassiveAbilitySO Constricting => LoadedAssetsHandler.GetPassive("Constricting_PA");
        static public BasePassiveAbilitySO Construct => LoadedAssetsHandler.GetPassive("Construct_PA");
        static public BasePassiveAbilitySO Delicate => LoadedAssetsHandler.GetPassive("Delicate_PA");
        static public BasePassiveAbilitySO Dying => LoadedAssetsHandler.GetPassive("Dying_PA");
        static public BasePassiveAbilitySO Enfeebled => LoadedAssetsHandler.GetPassive("Enfeebled_PA");
        static public BasePassiveAbilitySO EssenceBlue => LoadedAssetsHandler.GetPassive("Essence_Blue_PA");
        static public BasePassiveAbilitySO EssencePurple => LoadedAssetsHandler.GetPassive("Essence_Purple_PA");
        static public BasePassiveAbilitySO EssenceRed => LoadedAssetsHandler.GetPassive("Essence_Red_PA");
        static public BasePassiveAbilitySO EssenceYellow => LoadedAssetsHandler.GetPassive("Essence_Yellow_PA");
        static public BasePassiveAbilitySO EssenceUntethered => LoadedAssetsHandler.GetPassive("Essence_Untethered_PA");
        static public BasePassiveAbilitySO Fatalism => LoadedAssetsHandler.GetPassive("Fatalism_PA");
        static public BasePassiveAbilitySO FinancialHyperinflation => LoadedAssetsHandler.GetPassive("FinancialHyperinflation_PA");
        static public BasePassiveAbilitySO Fleeting1 => LoadedAssetsHandler.GetPassive("Fleeting_1_PA");
        static public BasePassiveAbilitySO Fleeting3IgnoreFirst => LoadedAssetsHandler.GetPassive("Fleeting_3_IgnoreFirst_PA");
        static public BasePassiveAbilitySO Fleeting3 => LoadedAssetsHandler.GetPassive("Fleeting_3_PA");
        static public BasePassiveAbilitySO Fleeting4 => LoadedAssetsHandler.GetPassive("Fleeting_4_PA");
        static public BasePassiveAbilitySO Fleeting6 => LoadedAssetsHandler.GetPassive("Fleeting_6_PA");
        static public BasePassiveAbilitySO Flonked => LoadedAssetsHandler.GetPassive("Flonked_PA");
        static public BasePassiveAbilitySO Focus => LoadedAssetsHandler.GetPassive("Focus_PA");
        static public BasePassiveAbilitySO ForbiddenFruitInHerImage => LoadedAssetsHandler.GetPassive("ForbiddenFruit_InHerImage_PA");
        static public BasePassiveAbilitySO ForbiddenFruitInHisImage => LoadedAssetsHandler.GetPassive("ForbiddenFruit_InHisImage_PA");
        static public BasePassiveAbilitySO Forgetful => LoadedAssetsHandler.GetPassive("Forgetful_PA");
        static public BasePassiveAbilitySO Formless => LoadedAssetsHandler.GetPassive("Formless_PA");
        static public BasePassiveAbilitySO FullReset => LoadedAssetsHandler.GetPassive("Decay_SaveFile_PA");
        static public BasePassiveAbilitySO Immortal => LoadedAssetsHandler.GetPassive("Immortal_PA");
        static public BasePassiveAbilitySO Inanimate => LoadedAssetsHandler.GetPassive("Inanimate_PA");
        static public BasePassiveAbilitySO Infantile => LoadedAssetsHandler.GetPassive("Infantile_PA");
        static public BasePassiveAbilitySO Inferno => LoadedAssetsHandler.GetPassive("Inferno_PA");
        static public BasePassiveAbilitySO Infestation0 => LoadedAssetsHandler.GetPassive("Infestation_0_PA");
        static public BasePassiveAbilitySO Infestation1 => LoadedAssetsHandler.GetPassive("Infestation_1_PA");
        static public BasePassiveAbilitySO Infestation2 => LoadedAssetsHandler.GetPassive("Infestation_2_PA");
        static public BasePassiveAbilitySO Leaky1 => LoadedAssetsHandler.GetPassive("Leaky_1_PA");
        static public BasePassiveAbilitySO Leaky3 => LoadedAssetsHandler.GetPassive("Leaky_3_PA");
        static public BasePassiveAbilitySO Masochism1 => LoadedAssetsHandler.GetPassive("Masochism_1_PA");
        static public BasePassiveAbilitySO MultiAttack2 => LoadedAssetsHandler.GetPassive("MultiAttack_2_PA");
        static public BasePassiveAbilitySO MultiAttack3 => LoadedAssetsHandler.GetPassive("MultiAttack_3_PA");
        static public BasePassiveAbilitySO MultiAttack4 => LoadedAssetsHandler.GetPassive("MultiAttack_4_PA");
        static public BasePassiveAbilitySO MultiAttack50 => LoadedAssetsHandler.GetPassive("MultiAttack_50_PA");
        static public BasePassiveAbilitySO MultiAttack5 => LoadedAssetsHandler.GetPassive("MultiAttack_5_PA");
        static public BasePassiveAbilitySO Obscure => LoadedAssetsHandler.GetPassive("Obscure_PA");
        static public BasePassiveAbilitySO Omnipresent => LoadedAssetsHandler.GetPassive("Omnipresent_PA");
        static public BasePassiveAbilitySO Overexert10 => LoadedAssetsHandler.GetPassive("Overexert_10_PA");
        static public BasePassiveAbilitySO Overexert1 => LoadedAssetsHandler.GetPassive("Overexert_1_PA");
        static public BasePassiveAbilitySO Overexert2 => LoadedAssetsHandler.GetPassive("Overexert_2_PA");
        static public BasePassiveAbilitySO Overexert6 => LoadedAssetsHandler.GetPassive("Overexert_6_PA");
        static public BasePassiveAbilitySO PanicAttack => LoadedAssetsHandler.GetPassive("PanicAttack_PA");
        static public BasePassiveAbilitySO ParasiteMutualism => LoadedAssetsHandler.GetPassive("Parasite_Mutualism_PA");
        static public BasePassiveAbilitySO ParasiteMutualismTapeWormPills => LoadedAssetsHandler.GetPassive("Parasite_Mutualism_TapeWormPills_PA");
        static public BasePassiveAbilitySO ParasiteParasitism => LoadedAssetsHandler.GetPassive("Parasite_Parasitism_PA");
        static public BasePassiveAbilitySO Pure => LoadedAssetsHandler.GetPassive("Pure_PA");
        static public BasePassiveAbilitySO RebornToInHerImage => LoadedAssetsHandler.GetPassive("RebornTo_InHerImage_PA");
        static public BasePassiveAbilitySO RebornToInHisImage => LoadedAssetsHandler.GetPassive("RebornTo_InHisImage_PA");
        static public BasePassiveAbilitySO Skittish10 => LoadedAssetsHandler.GetPassive("Skittish_10_PA");
        static public BasePassiveAbilitySO Skittish2 => LoadedAssetsHandler.GetPassive("Skittish_2_PA");
        static public BasePassiveAbilitySO Skittish3 => LoadedAssetsHandler.GetPassive("Skittish_3_PA");
        static public BasePassiveAbilitySO Skittish => LoadedAssetsHandler.GetPassive("Skittish_PA");
        static public BasePassiveAbilitySO Slippery => LoadedAssetsHandler.GetPassive("Slippery_PA");
        static public BasePassiveAbilitySO Theophobia => LoadedAssetsHandler.GetPassive("Theophobia_PA");
        static public BasePassiveAbilitySO Transfusion => LoadedAssetsHandler.GetPassive("Transfusion_PA");
        static public BasePassiveAbilitySO TwoFaced => LoadedAssetsHandler.GetPassive("TwoFaced_PA");
        static public BasePassiveAbilitySO Unstable => LoadedAssetsHandler.GetPassive("Unstable_PA");
        static public BasePassiveAbilitySO Withering => LoadedAssetsHandler.GetPassive("Withering_PA");

        static public BasePassiveAbilitySO Example_Parental_Vengeance => LoadedAssetsHandler.GetPassive("Parental_Vengeance_PA");
        static public BasePassiveAbilitySO Example_BonusAttack_Mangle => LoadedAssetsHandler.GetPassive("Mangle_PA");
        static public BasePassiveAbilitySO Example_Decay_MudLung => LoadedAssetsHandler.GetPassive("Decay_MudLung_Mung_PA");
        #endregion

        #region Passive Generator Fields
        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedAbomination = new()
        {
            { 1, Abomination1 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedAnointed = new()
        {
            { 1, Anointed1 },
            { 2, Anointed2 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedBoneSpurs = new()
        {
            { 1, BoneSpurs1 },
            { 2, BoneSpurs2 },
            { 3, BoneSpurs3 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedOldBoneSpurs = [];

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedCashout = new()
        {
            { 1, Cashout }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedCatalyst = new()
        {
            { 1, Catalyst }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedConstruct = new()
        {
            { 1, Construct }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedConstructUncapped = [];

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedFleeting = new()
        {
            { 1, Fleeting1 },
            { 3, Fleeting3 },
            { 4, Fleeting4 },
            { 6, Fleeting6 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedFleetingIgnoreFirst = new()
        {
            { 3, Fleeting3IgnoreFirst }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedFormless = new()
        {
            { 1, Formless }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedInfantile = new()
        {
            { 1, Infantile }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedInferno = new()
        {
            { 1, Inferno }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedInfestation = new()
        {
            { 0, Infestation0 },
            { 1, Infestation1 },
            { 2, Infestation2 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedLeaky = new()
        {
            { 1, Leaky1 },
            { 3, Leaky3 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedMasochism = new()
        {
            { 1, Masochism1 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedMultiAttack = new()
        {
            { 2, MultiAttack2 },
            { 3, MultiAttack3 },
            { 4, MultiAttack4 },
            { 5, MultiAttack5 },
            { 50, MultiAttack50 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedOverexert = new()
        {
            { 1, Overexert1 },
            { 2, Overexert2 },
            { 6, Overexert6 },
            { 10, Overexert10 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedSkittish = new()
        {
            { 1, Skittish },
            { 2, Skittish2 },
            { 3, Skittish3 },
            { 10, Skittish10 }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedSlippery = new()
        {
            { 1, Slippery }
        };

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedUnstable = new()
        {
            { 1, Unstable }
        };

        private static readonly Dictionary<int, string> NumTimesStrings = new()
        {
            { 1, "once" },
            { 2, "twice" },
            { 3, "thrice" },
            { 4, "four times" },
            { 5, "five times" },
            { 6, "six times" },
            { 7, "seven times" },
            { 8, "eight times" },
            { 9, "nine times" },
            { 10, "ten times" },
            { 11, "eleven times" },
            { 12, "twelve times" },
            { 13, "thirteen times" },
            { 14, "fourteen times" },
            { 15, "fifteen times" },
            { 16, "sixteen times" },
            { 17, "seventeen times" },
            { 18, "eighteen times" },
            { 19, "nineteen times" },
            { 20, "twenty times" },
        };

        private static readonly EffectorConditionSO Abomination_EffectorCondition = Abomination1.conditions[0];

        private static readonly EffectSO Anointed_DivineProtection_Effect = (Anointed1 as PerformEffectPassiveAbility).effects[0].effect;

        private static readonly EffectSO BoneSpurs_Damage_Effect = (BoneSpurs1 as PerformEffectPassiveAbility).effects[0].effect;
        private static readonly UnitStoreData_BasicSO BoneSpurs_ExtraDamage_SV = BoneSpurs1.specialStoredData;
        private static readonly EffectorConditionSO BoneSpurs_EffectorCondition = BoneSpurs1.conditions[0];

        private static readonly EffectSO Cashout_ProduceMoney_Effect = (Cashout as PerformEffectAddingResultPassiveAbility).effects[0].effect;

        private static readonly LinkedSE_SO Catalyst_Linked_StatusEffect = (Catalyst as CatalystPassiveAbility)._LinkedStatus;
        private static readonly EffectorConditionSO Catalyst_EffectorCondition = Catalyst.conditions[0];

        private static readonly EffectSO Construct_CheckAbilities_Effect = (Construct as Connection_PerformEffectPassiveAbility).connectionEffects[0].effect;
        private static readonly EffectSO Construct_AddAbility_Effect = (Construct as Connection_PerformEffectPassiveAbility).connectionEffects[1].effect;
        private static readonly EffectConditionSO Construct_CheckAbilities_EffectCondition = (Construct as Connection_PerformEffectPassiveAbility).connectionEffects[1].condition;

        private static readonly EffectorConditionSO Formless_EffectorCondition = Formless.conditions[0];

        private static readonly EffectSO Inferno_ApplyFire_Effect = (Inferno as PerformEffectPassiveAbility).effects[0].effect;

        private static readonly EffectorConditionSO Infestation_EffectorCondition = Infestation1.conditions[0];
        private static readonly UnitStoreData_BasicSO Infestation_Increase_SV = Infestation1.specialStoredData;

        private static readonly EffectSO Leaky_Pigment_Effect = (Leaky1 as PerformEffectPassiveAbility).effects[0].effect;
        private static readonly EffectorConditionSO Leaky_EffectorCondition = Leaky1.conditions[0];

        private static readonly EffectSO Masochism_AddTurn_Effect = (Masochism1 as PerformEffectPassiveAbility).effects[0].effect;
        private static readonly EffectorConditionSO Masochism_EffectorCondition = Masochism1.conditions[0];

        private static readonly EffectorConditionSO MultiAttack_EffectorCondition = MultiAttack2.conditions[0];

        private static readonly EffectorConditionSO Overexert_EffectorCondition_2 = Overexert2.conditions[1];

        private static readonly EffectSO Skittish_Move_Effect = (Skittish as PerformEffectPassiveAbility).effects[0].effect;
        private static readonly EffectorConditionSO Skittish_EffectorCondition = Skittish.conditions[0];

        private static readonly EffectSO Slippery_Move_Effect = (Slippery as PerformEffectPassiveAbility).effects[0].effect;
        private static readonly EffectorConditionSO Slippery_EffectorCondition = Slippery.conditions[0];

        private static readonly EffectSO Unstable_RandomizePigment_Effect = (Unstable as PerformEffectPassiveAbility).effects[0].effect;
        #endregion

        #region Basic Passvie Functions
        static public BasePassiveAbilitySO GetCustomPassive(string passiveID)
        {
            return LoadedAssetsHandler.GetPassive(passiveID);
        }
        static public void AddCustomPassiveToPool(string DatabaseID_PA, string passiveDisplayName, BasePassiveAbilitySO passive)
        {
            passive.name = DatabaseID_PA;
            passive._passiveName = passiveDisplayName;
            if (DatabaseID_PA == "")
            {
                Debug.LogError($"This passive has no ID! Do it by setting it like this: myPassive.name = myID");
                return;
            }

            LoadedDBsHandler.PassiveDB.AddNewPassive(passive.name, passive);
        }
        #endregion

        #region Passive Generators
        public static BasePassiveAbilitySO AbominationGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedAbomination, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<IntegerSetterByStoredValuePassiveAbility>();

                pa.name = $"Abomination_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Abomination.ToString();

                pa._passiveName = $"Abomination ({x})";
                pa._characterDescription = "This passive is not meant for party members.";
                pa._enemyDescription = $"This enemy will perform {Mathf.Abs(x)} {(x < 0 ? "less" : "additional")} actions for every turn it remains alive.";

                pa.passiveIcon = Abomination1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.AttacksPerTurn };

                pa.conditions = new EffectorConditionSO[] { Abomination_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = false;
                pa.specialStoredData = null;

                pa.unitStoredDataID = UnitStoredValueNames_GameIDs.AbominationPA.ToString();
                pa._postIncreaseStored = true;
                pa.postIncreaseValue = x;

                return pa;
            });
        }

        public static BasePassiveAbilitySO AnointedGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedAnointed, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Anointed_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Anointed.ToString();

                pa._passiveName = $"Anointed ({x})";
                pa._characterDescription = "On turn start, this party member blesses the opposing enemy.";
                pa._enemyDescription = "On turn start, this enemy blesses the opposing party members.";

                pa.passiveIcon = Anointed1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnTurnStart };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Anointed_DivineProtection_Effect, x, Targeting.Slot_Front)
                };

                pa.conditions = [];
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO BoneSpursGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedBoneSpurs, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"BoneSpurs_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.BoneSpurs.ToString();

                pa._passiveName = $"Bone Spurs ({x})";
                pa._characterDescription = $"Deal {x} indirect damage to the Opposing enemy upon receiving direct damage, even if the damage dealt is 0.";
                pa._enemyDescription = $"Deal {x} indirect damage to the Opposing party member upon receiving direct damage, even if the damage dealt is 0.";

                pa.passiveIcon = BoneSpurs1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnBeingDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(BoneSpurs_Damage_Effect, amount, Targeting.Slot_Front),
                };

                pa.conditions = new EffectorConditionSO[] { BoneSpurs_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = BoneSpurs_ExtraDamage_SV;

                return pa;
            });
        }

        public static BasePassiveAbilitySO OldBoneSpursGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedOldBoneSpurs, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"OldBoneSpurs_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.BoneSpurs.ToString();

                pa._passiveName = $"Bone Spurs ({x})";
                pa._characterDescription = $"Deal {x} indirect damage to the Opposing enemy upon receiving direct damage.";
                pa._enemyDescription = $"Deal {x} indirect damage to the Opposing party member upon receiving direct damage.";

                pa.passiveIcon = BoneSpurs1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(BoneSpurs_Damage_Effect, amount, Targeting.Slot_Front),
                };

                pa.conditions = [];
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = BoneSpurs_ExtraDamage_SV;

                return pa;
            });
        }

        public static BasePassiveAbilitySO CashoutGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedCashout, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectAddingResultPassiveAbility>();

                pa.name = $"Cashout_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Cashout.ToString();

                pa._passiveName = $"Cashout ({x})";
                pa._characterDescription = $"This party member is made of money. (Upon receiving {x} or more damage, produce coins equal to the damage received)";
                pa._enemyDescription = $"This enemy is made of money. (Upon receiving {x} or more damage, produce coins equal to the damage received)";

                pa.passiveIcon = Cashout.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Cashout_ProduceMoney_Effect, 1)
                };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { condition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                pa._useIntReferenceResult = true;

                return pa;
            });
        }

        public static BasePassiveAbilitySO CatalystGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedCatalyst, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<CatalystPassiveAbility>();

                pa.name = $"Catalyst_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Catalyst.ToString();

                pa._passiveName = $"Catalyst ({x})";
                pa._characterDescription = $"Whenever this party member receives {x} or more direct damage, all party members and enemies with linked will also receive damage.";
                pa._enemyDescription = $"Whenever this enemy receives {x} or more direct damage, all party members and enemies with linked will also receive damage.";

                pa.passiveIcon = Catalyst.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { Catalyst_EffectorCondition, condition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                pa._LinkedStatus = Catalyst_Linked_StatusEffect;
                pa._dmgTypeID = "Dmg_Linked";

                return pa;
            });
        }

        public static BasePassiveAbilitySO ConstructGenerator(int amount, bool hasAbilityCap = true)
        {
            if (amount < 0)
            {
                Debug.LogError("Negative amounts of Construct are not supported.");

                return null;
            }

            return GetOrCreatePassive(hasAbilityCap ? GeneratedConstruct : GeneratedConstructUncapped, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();

                pa.name = $"Construct_{x}{(hasAbilityCap ? string.Empty : "_NoAbilityCap")}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Construct.ToString();

                pa._passiveName = $"Construct ({x})";
                pa._characterDescription = $"Add {x} random item abilities at the beginning of combat.";
                pa._enemyDescription = $"Add {x} random item abilities at the beginning of combat.";

                pa.passiveIcon = Construct.passiveIcon;

                pa._triggerOn = [];

                pa.conditions = [];
                pa.doesPassiveTriggerInformationPanel = false;
                pa.specialStoredData = null;

                if (hasAbilityCap)
                {
                    var effects = new List<EffectInfo>();

                    var previousAmounts = new List<int>();
                    var wasSuccessful = new List<bool>();

                    for(int i = x; i > 0; i--)
                    {
                        // Not too proud of this solution, but it should work.
                        // The idea is to check every possible amount of abilities that can be added, and if it's possible to add that number of abilities and all previous ability checks failed, add that number of abilities.

                        MultiPreviousEffectCondition checkCond = null;

                        if(previousAmounts.Count > 0)
                        {
                            checkCond = ScriptableObject.CreateInstance<MultiPreviousEffectCondition>();

                            checkCond.previousAmount = [.. previousAmounts];
                            checkCond.wasSuccessful = [.. wasSuccessful];
                        }

                        effects.Add(Effects.GenerateEffect(Construct_CheckAbilities_Effect, 6 - i, null, checkCond));
                        effects.Add(Effects.GenerateEffect(Construct_AddAbility_Effect, i, null, Construct_CheckAbilities_EffectCondition));

                        previousAmounts.Add((x - i + 1) * 2);
                        wasSuccessful.Add(false);
                    }

                    pa.connectionEffects = [.. effects];
                }
                else
                {
                    pa.connectionEffects = new EffectInfo[]
                    {
                        Effects.GenerateEffect(Construct_AddAbility_Effect, x)
                    };
                }

                pa.disconnectionEffects = [];
                pa.immediateEffect = true;

                return pa;
            });
        }

        public static BasePassiveAbilitySO FleetingGenerator(int amount, bool ignoreFirstTurn = false)
        {
            return GetOrCreatePassive(ignoreFirstTurn ? GeneratedFleetingIgnoreFirst : GeneratedFleeting, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<FleetingPassiveAbility>();

                pa.name = $"Fleeting_{x}{(ignoreFirstTurn ? "_IgnoreFirst" : string.Empty)}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Fleeting.ToString();

                pa._passiveName = $"Fleeting ({x})";
                pa._characterDescription = $"After {x} rounds this party member will flee... Coward.";
                pa._enemyDescription = $"After {x} rounds this enemy will flee.";

                pa.passiveIcon = Fleeting1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnRoundFinished };

                pa.conditions = [];
                pa.doesPassiveTriggerInformationPanel = false;
                pa.specialStoredData = null;

                pa._ignoreFirstTurn = ignoreFirstTurn;
                pa._turnsBeforeFleeting = x;
                pa.fleeting_USD = UnitStoredValueNames_GameIDs.FleetingPA.ToString();
                pa.fleetingIgnoreFirstTurn_USD = UnitStoredValueNames_GameIDs.FleetingPA_IgnoreFirstTurn.ToString();

                return pa;
            });
        }

        public static BasePassiveAbilitySO FormlessGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedFormless, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<FormlessPassiveAbility>();

                pa.name = $"Formless_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Formless.ToString();

                pa._passiveName = $"Formless ({x})";
                pa._characterDescription = "This passive is not meant for party members.";
                pa._enemyDescription = $"Upon receiving {x} or more direct damage reroll one of this enemies abilties.";

                pa.passiveIcon = Formless.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { condition, Formless_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO InfantileGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedInfantile, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<InfantilePassiveAbility>();

                pa.name = $"Infantile_{amount}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Infantile.ToString();

                pa._passiveName = $"Infantile ({x})";
                pa._characterDescription = "This passive is not meant for party members.";
                pa._enemyDescription = $"Upon receiving {x} or more direct damage this enemy will cause any parental enemies to perform an action in retribution.";

                pa.passiveIcon = Infantile.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { condition };
                pa.doesPassiveTriggerInformationPanel = false;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO InfernoGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedInferno, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Inferno_{amount}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Inferno.ToString();

                pa._passiveName = $"Inferno ({x})";
                pa._characterDescription = $"On turn start, this party member applies {x} Fire to their current position.";
                pa._enemyDescription = $"On turn start, this enemy applies {x} Fire to its current position.";

                pa.passiveIcon = Inferno.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnTurnStart };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Inferno_ApplyFire_Effect, x, Targeting.Slot_SelfSlot)
                };

                pa.conditions = [];
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO InfestationGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedInfestation, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<InfestationPassiveAbility>();

                pa.name = $"Infestation_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Infestation.ToString();

                pa._passiveName = $"Infestation ({x})";
                pa._characterDescription = $"This party member {(x < 0 ? "weakens" : "boosts")} the damage dealt by all other party members and enemies with Infestation by {Mathf.Abs(x)}.";
                pa._enemyDescription = $"This enemy {(x < 0 ? "weakens" : "boosts")} the damage dealt by all other enemies and party members with Infestation by {Mathf.Abs(x)}.";

                pa.passiveIcon = Infestation1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnWillApplyDamage };

                pa.conditions = new EffectorConditionSO[] { Infestation_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = Infestation_Increase_SV;

                pa._addsXInfestationEnemies = x;
                pa._selfDamageMultiplierPerEnemy = 1;
                pa._useDealt = true;
                pa.infestation_USD = UnitStoredValueNames_GameIDs.InfestationPA.ToString();

                return pa;
            });
        }

        public static BasePassiveAbilitySO LeakyGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedLeaky, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Leaky_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Leaky.ToString();

                pa._passiveName = $"Leaky ({x})";
                pa._characterDescription = $"Upon receiving direct damage, this character generates {x} extra pigment of its health colour.";
                pa._enemyDescription = $"Upon receiving direct damage, this enemy generates {x} extra pigment of its health colour.";

                pa.passiveIcon = Leaky1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Leaky_Pigment_Effect, x)
                };

                pa.conditions = new EffectorConditionSO[] { Leaky_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO MasochismGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedMasochism, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Masochism_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Masochism.ToString();

                pa._passiveName = $"Masochism ({x})";
                pa._characterDescription = "This Passive Ability is not meant for characters.";
                pa._enemyDescription = $"Upon receiving any kind of damage, this enemy will queue {x} additional abilities.";

                pa.passiveIcon = Masochism1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Masochism_AddTurn_Effect, x)
                };

                pa.conditions = new EffectorConditionSO[] { Masochism_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO MultiAttackGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedMultiAttack, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<IntegerSetterPassiveAbility>();

                pa.name = $"MultiAttack_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.MultiAttack.ToString();

                pa._passiveName = $"MultiAttack ({x})";
                pa._characterDescription = "This passive is not meant for party members.";
                pa._enemyDescription = $"This enemy will perform {x} actions each turn.";

                pa.passiveIcon = MultiAttack2.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.AttacksPerTurn };

                pa.conditions = new EffectorConditionSO[] { MultiAttack_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = false;
                pa.specialStoredData = null;

                pa.integerValue = x - 1;
                pa._isItAdditive = true;

                return pa;
            });
        }

        public static BasePassiveAbilitySO OverexertGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedOverexert, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<OverexertPassiveAbility>();

                pa.name = $"Overexert_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Overexert.ToString();

                pa._passiveName = $"Overexert ({x})";
                pa._characterDescription = "This passive is not meant for party members.";
                pa._enemyDescription = $"Upon receiving {x} or more direct damage, cancel 1 of this enemy's actions.";

                pa.passiveIcon = Overexert1.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { condition, Overexert_EffectorCondition_2 };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO SkittishGenerator(int amount)
        {
            if(amount < 0)
            {
                Debug.LogError("Negative amounts of Skittish are not supported.");

                return null;
            }

            return GetOrCreatePassive(GeneratedSkittish, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Skittish_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Skittish.ToString();

                pa._passiveName = $"Skittish ({x})";
                pa._characterDescription = $"Upon performing an attack this party member will attempt to move to the Left or Right {GetNumTimes(x)}.";
                pa._enemyDescription = $"Upon performing an attack this enemy will attempt to move to the Left or Right {GetNumTimes(x)}.";

                pa.passiveIcon = Skittish.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnAbilityUsed };
                pa.effects = new EffectInfo[x];

                for(int i = 0; i < x; i++)
                {
                    pa.effects[i] = Effects.GenerateEffect(Skittish_Move_Effect, 0, Targeting.Slot_SelfSlot);
                }

                pa.conditions = new EffectorConditionSO[] { Skittish_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO SlipperyGenerator(int amount)
        {
            if (amount < 0)
            {
                Debug.LogError("Negative amounts of Slippery are not supported.");

                return null;
            }

            return GetOrCreatePassive(GeneratedSlippery, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Slippery_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Slippery.ToString();

                pa._passiveName = $"Slippery ({x})";
                pa._characterDescription = $"Upon taking direct damage this party member will attempt to move to the Left or Right {GetNumTimes(x)}.";
                pa._enemyDescription = $"Upon taking direct damage this enemy will attempt to move to the Left or Right {GetNumTimes(x)}.";

                pa.passiveIcon = Slippery.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };
                pa.effects = new EffectInfo[x];

                for(int i = 0; i < x; i++)
                {
                    pa.effects[i] = Effects.GenerateEffect(Slippery_Move_Effect, 0, Targeting.Slot_SelfSlot);
                }

                pa.conditions = new EffectorConditionSO[] { Slippery_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO UnstableGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedUnstable, amount, x =>
            {
                var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

                pa.name = $"Unstable_{x}_PA";
                pa.m_PassiveID = PassiveType_GameIDs.Unstable.ToString();

                pa._passiveName = $"Unstable ({x})";
                pa._characterDescription = $"Upon taking {x} or more damage this party member will randomize all stored pigment.";
                pa._enemyDescription = $"Upon taking {x} or more damage this enemy will randomize all stored pigment.";

                pa.passiveIcon = Unstable.passiveIcon;

                pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };
                pa.effects = new EffectInfo[]
                {
                    Effects.GenerateEffect(Unstable_RandomizePigment_Effect, 0, Targeting.Slot_SelfSlot)
                };

                var condition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                condition.compareValue = x;

                pa.conditions = new EffectorConditionSO[] { condition, Formless_EffectorCondition };
                pa.doesPassiveTriggerInformationPanel = true;
                pa.specialStoredData = null;

                return pa;
            });
        }

        public static BasePassiveAbilitySO ParentalGenerator(ExtraAbilityInfo parentalAbility)
        {
            if(parentalAbility == null || parentalAbility.ability == null)
            {
                Debug.LogError("Null parental ability.");

                return null;
            }

            var pa = ScriptableObject.CreateInstance<ParentalPassiveAbility>();

            var trimmedAbilityId = parentalAbility.ability.name;

            if (trimmedAbilityId.EndsWith("_A"))
                trimmedAbilityId = trimmedAbilityId.Substring(0, trimmedAbilityId.Length - "_A".Length);

            pa.name = $"Parental_{trimmedAbilityId}_PA";
            pa.m_PassiveID = PassiveType_GameIDs.Parental.ToString();

            pa._passiveName = $"Parental";
            pa._characterDescription = "This passive is not meant for party members.";
            pa._enemyDescription = $"If an infantile enemy receives direct damage, this enemy will perform \"{parentalAbility.ability._abilityName}\" in retribution.";

            pa.passiveIcon = Example_Parental_Vengeance.passiveIcon;

            pa._triggerOn = [];

            pa.conditions = [];
            pa.doesPassiveTriggerInformationPanel = false;
            pa.specialStoredData = null;

            pa._parentalAbility = parentalAbility;

            return pa;
        }

        public static BasePassiveAbilitySO BonusAttackGenerator(ExtraAbilityInfo bonusAbility)
        {
            if(bonusAbility == null || bonusAbility.ability == null)
            {
                Debug.LogError("Null bonus ability.");

                return null;
            }

            var pa = ScriptableObject.CreateInstance<ExtraAttackPassiveAbility>();

            var trimmedAbilityId = bonusAbility.ability.name;

            if (trimmedAbilityId.EndsWith("_A"))
                trimmedAbilityId = trimmedAbilityId.Substring(0, trimmedAbilityId.Length - "_A".Length);

            pa.name = $"{trimmedAbilityId}_PA";
            pa.m_PassiveID = trimmedAbilityId;

            pa._passiveName = bonusAbility.ability._abilityName;
            pa._characterDescription = "This passive is not meant for party members.";
            pa._enemyDescription = $"This enemy performs \"{bonusAbility.ability._abilityName}\" as an additional attack.";

            pa.passiveIcon = Example_BonusAttack_Mangle.passiveIcon;

            pa._triggerOn = new TriggerCalls[] { TriggerCalls.ExtraAdditionalAttacks };

            pa.conditions = [];
            pa.doesPassiveTriggerInformationPanel = false;
            pa.specialStoredData = null;

            pa._extraAbility = bonusAbility;

            return pa;
        }

        public static BasePassiveAbilitySO DecayGenerator(EnemySO decayEnemy, int chance = 100)
        {
            if(decayEnemy == null)
            {
                Debug.LogError("Null decay enemy");

                return null;
            }

            var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

            var trimmedEnemyId = decayEnemy.name;

            if(trimmedEnemyId.EndsWith("_EN"))
                trimmedEnemyId = trimmedEnemyId.Substring(0, trimmedEnemyId.Length - "_EN".Length);

            pa.name = $"Decay_{trimmedEnemyId}_{chance}_PA";
            pa.m_PassiveID = PassiveType_GameIDs.Decay.ToString();

            pa._passiveName = "Decay";
            pa._characterDescription = $"Upon death this party member has a {chance}% chance of spawning a {decayEnemy._enemyName}.";
            pa._enemyDescription = $"Upon death this enemy has a {chance}% chance of spawning a {decayEnemy._enemyName}.";

            pa.passiveIcon = Example_Decay_MudLung.passiveIcon;

            var spawnEffect = ScriptableObject.CreateInstance<SpawnEnemyInSlotFromEntryEffect>();
            spawnEffect.enemy = decayEnemy;
            spawnEffect._spawnTypeID = "Spawn_Basic";
            spawnEffect.givesExperience = false;
            spawnEffect.trySpawnAnywhereIfFail = false;

            pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnDeath };
            pa.effects = new EffectInfo[]
            {
                Effects.GenerateEffect(spawnEffect, 0, Targeting.Slot_SelfSlot)
            };

            if(chance < 100)
            {
                var condition = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
                condition.triggerPercentage = chance;

                pa.conditions = new EffectorConditionSO[] { condition };
            }
            else
            {
                pa.conditions = [];
            }

            pa.doesPassiveTriggerInformationPanel = true;
            pa.specialStoredData = null;

            return pa;
        }

        public static BasePassiveAbilitySO EssenceGenerator(List<ManaColorSO> addedLuckyOptions, Sprite passiveSprite, string id = "Essence_{0}_PA", string essenceName = "{0} Essence", string essenceDescription = "Allows lucky pigment to be toggled to {0}.")
        {
            if(addedLuckyOptions == null)
            {
                Debug.LogError("Null lucky options");

                return null;
            }

            var pa = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();

            pa.name = string.Format(id, string.Join("_", addedLuckyOptions.Select(x => x != null ? x.pigmentID : "")));
            pa.m_PassiveID = PassiveType_GameIDs.Essence.ToString();

            var pigmentsString = "";

            for(int i = 0; i < addedLuckyOptions.Count; i++)
            {
                if (i > 0)
                {
                    if (i == addedLuckyOptions.Count - 1)
                        pigmentsString += " and ";

                    else
                        pigmentsString += ", ";
                }

                var pigment = addedLuckyOptions[i];

                if (pigment == null)
                    continue;

                pigmentsString += pigment.pigmentID;
            }

            pa._passiveName = string.Format(essenceName, pigmentsString);
            pa._characterDescription = string.Format(essenceDescription, pigmentsString);
            pa._enemyDescription = string.Format(essenceDescription, pigmentsString);

            pa.passiveIcon = passiveSprite;

            pa._triggerOn = new TriggerCalls[] { TriggerCalls.OnCombatStart };

            var effects = new List<EffectInfo>();

            foreach(var pigment in addedLuckyOptions)
            {
                if (pigment == null)
                    continue;

                var luckyEffect = ScriptableObject.CreateInstance<LuckyBlueColorSetEffect>();
                luckyEffect._luckyColor = pigment;

                effects.Add(Effects.GenerateEffect(luckyEffect));
            }

            pa.effects = [.. effects];

            pa.conditions = [];
            pa.doesPassiveTriggerInformationPanel = true;
            pa.specialStoredData = null;

            return pa;
        }

        private static string GetNumTimes(int count)
        {
            if (NumTimesStrings.TryGetValue(count, out var str))
            {
                return str;
            }
            return $"{count} times";
        }

        private static TValue GetOrCreatePassive<TKey, TValue>(IDictionary<TKey, TValue> readFrom, TKey key, Func<TKey, TValue> create)
        {
            if (readFrom.TryGetValue(key, out var value))
                return value;

            return readFrom[key] = create(key);
        }
        #endregion
    }
}
