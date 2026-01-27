using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BrutalAPI
{
    static public class Targeting
    {
        #region Generic Targeting
        static public BaseCombatTargettingSO Generic_Ally_Middle => LoadedDBsHandler.MiscDB.GetTargeting("GenericTarget_Ally_Middle");
        static public BaseCombatTargettingSO Generic_Opponent_Middle => LoadedDBsHandler.MiscDB.GetTargeting("GenericTarget_Opponent_Middle");
        #endregion

        #region Custom Enemy Targeting
        static public BaseCombatTargettingSO BigEnemy_Front_Offset_0 => LoadedDBsHandler.MiscDB.GetTargeting("SingleSide_ST_Front_Off_0");
        static public BaseCombatTargettingSO BigEnemy_Front_Offset_1 => LoadedDBsHandler.MiscDB.GetTargeting("SingleSide_ST_Front_Off_1");
        static public BaseCombatTargettingSO BigEnemy_Front_Offset_0and2 => LoadedDBsHandler.MiscDB.GetTargeting("SingleSide_ST_Front_Off_0_2");
        #endregion

        #region By Slot Index
        static public BaseCombatTargettingSO Slot_AlliesAllLefts => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AlliesAllLefts");
        static public BaseCombatTargettingSO Slot_AlliesAllRights => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AlliesAllRights");
        static public BaseCombatTargettingSO Slot_AllyFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllyFarSides");
        static public BaseCombatTargettingSO Slot_AllyLeft => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllyLeft");
        static public BaseCombatTargettingSO Slot_AllyRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllyRight");
        static public BaseCombatTargettingSO Slot_AllyRightAndFarRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllyRightAndFarRight");
        static public BaseCombatTargettingSO Slot_AllySides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllySides");
        static public BaseCombatTargettingSO Slot_AllySidesAndFarRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllySidesAndFarRight");
        static public BaseCombatTargettingSO Slot_AllySidesAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllySidesAndFarSides");
        static public BaseCombatTargettingSO Slot_Front => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_Front");
        static public BaseCombatTargettingSO Slot_Front_ThenAllRights_ThenAllLefts => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_Front_ThenAllRights_ThenAllLefts");
        static public BaseCombatTargettingSO Slot_FrontAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_FrontAndFarSides");
        static public BaseCombatTargettingSO Slot_FrontAndRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_FrontAndRight");
        static public BaseCombatTargettingSO Slot_FrontAndRightAndFarRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_FrontAndRightAndFarRight");
        static public BaseCombatTargettingSO Slot_FrontAndSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_FrontAndSides");
        static public BaseCombatTargettingSO Slot_FrontAndSidesAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_FrontAndSidesAndFarSides");
        static public BaseCombatTargettingSO Slot_OpponentAllLefts => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentAllLefts");
        static public BaseCombatTargettingSO Slot_OpponentAllRights => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentAllRights");
        static public BaseCombatTargettingSO Slot_OpponentAllSlots => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentAllSlots");
        static public BaseCombatTargettingSO Slot_OpponentFarRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentFarRight");
        static public BaseCombatTargettingSO Slot_OpponentFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentFarSides");
        static public BaseCombatTargettingSO Slot_OpponentFarSidesAndFartherSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentFarSidesAndFartherSides");
        static public BaseCombatTargettingSO Slot_OpponentFarthestSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentFarthestSides");
        static public BaseCombatTargettingSO Slot_OpponentLeft => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentLeft");
        static public BaseCombatTargettingSO Slot_OpponentRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentRight");
        static public BaseCombatTargettingSO Slot_OpponentSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentSides");
        static public BaseCombatTargettingSO Slot_OpponentSidesAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_OpponentSidesAndFarSides");
        static public BaseCombatTargettingSO Slot_SelfAndFarRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndFarRight");
        static public BaseCombatTargettingSO Slot_SelfAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndFarSides");
        static public BaseCombatTargettingSO Slot_SelfAndLeft => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndLeft");
        static public BaseCombatTargettingSO Slot_SelfAndRight => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndRight");
        static public BaseCombatTargettingSO Slot_SelfAndSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndSides");
        static public BaseCombatTargettingSO Slot_SelfSlot => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfSlot");

        static public BaseCombatTargettingSO Slot_AllyAllSlots => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_AllyAllSlots");
        static public BaseCombatTargettingSO Slot_SelfAll_AndLeft => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_Self_All_AndLeft");
        static public BaseCombatTargettingSO Slot_SelfAll_AndSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndSides_All");
        static public BaseCombatTargettingSO Slot_SelfAll_AndSidesAndFarSides => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfAndSidesAndFarSides_All");
        static public BaseCombatTargettingSO Slot_SelfAll => LoadedDBsHandler.MiscDB.GetTargeting("SlotTarget_SelfSlots_All");
        #endregion

        #region All Units
        static public BaseCombatTargettingSO AllUnits => LoadedDBsHandler.MiscDB.GetTargeting("Targeting_AllUnits");
        #endregion

        #region By Unit Side
        static public BaseCombatTargettingSO Unit_AllAllies => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_AllAllies");
        static public BaseCombatTargettingSO Unit_AllAllySlots => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_AllAllySlots");
        static public BaseCombatTargettingSO Unit_AllOpponents => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_AllOpponents");
        static public BaseCombatTargettingSO Unit_AllOpponentSlots => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_AllOpponentSlots");
        static public BaseCombatTargettingSO Unit_OtherAllies => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_OtherAllies");
        static public BaseCombatTargettingSO Unit_OtherAlliesSlots => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_OtherAlliesSlots");
        #endregion

        #region By Unit Side Specific
        static public BaseCombatTargettingSO Spec_Unit_AllAllies_All_Status => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllAllies_All_Status");
        static public BaseCombatTargettingSO Spec_Unit_AllAllies_All_Status_Field => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllAllies_All_Status_Field");
        static public BaseCombatTargettingSO Spec_Unit_AllAllies_Strongest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllAllies_Health_Strongest");
        static public BaseCombatTargettingSO Spec_Unit_AllAllySlots_Strongest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllAllies_Slots_Health_Strongest");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_All_Status => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_All_Status");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_All_Status_Field => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_All_Status_Field");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_Furthest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_Distance_Furthest");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_DivineProtection_Status => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_DivineProtection_Status");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_Strongest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_Health_Strongest");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_Weakest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_Health_Weakest");
        static public BaseCombatTargettingSO Spec_Unit_AllOpponents_OilSlicked_Status => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_AllOpponents_OilSlicked_Status");
        static public BaseCombatTargettingSO Spec_Unit_OtherAllies_Weakest => LoadedDBsHandler.MiscDB.GetTargeting("UnitTarget_Spec_OtherAllies_Health_Weakest");
        #endregion

        #region Generators
        /// <summary>
        /// Creates a simple targeting object. Use <paramref name="slots"/> to mark the slots you want to target. 0 Would be Self or Front. 1 Right, -1 Left.
        /// Use <paramref name="targetAllies"/> to point out if you are targeting opponents or allies.
        /// IMPORTANT <paramref name="getAllSelfSlots"/> will be true when a Big Unit tries to target ALL their own slots. This is mostly used for Field effects.
        /// </summary>
        public static BaseCombatTargettingSO GenerateSlotTarget(int[] slots, bool targetAllies = false, bool getAllSelfSlots = false)

        {
            Targetting_BySlot_Index t = ScriptableObject.CreateInstance<Targetting_BySlot_Index>();
            t.getAllies = targetAllies;
            t.slotPointerDirections = slots;
            t.allSelfSlots = getAllSelfSlots;
            return t;
        }


        /// <summary>
        /// This function is used for Big Units that want to attack a single slot in front of them.
        /// <paramref name="frontalUnitOffsets"/> are the frontal slots you want your Big Unit to target, being 0 the leftmost slot the Big Unit occupies.
        /// <paramref name="pointerDirections"/> is an extra just in case you also want to target non-frontal slots. It is always set to 0 to attack front, but if you use 1 or -1 you could also attack the sides.
        /// </summary>
        public static BaseCombatTargettingSO GenerateBigUnitSlotTarget(int[] frontalUnitOffsets, int[] pointerDirections = null)
        {
            CustomOpponentTargetting_BySlot_Index t = ScriptableObject.CreateInstance<CustomOpponentTargetting_BySlot_Index>();
            
            t._frontOffsets = frontalUnitOffsets;
            t._slotPointerDirections = pointerDirections;
            if (pointerDirections == null)
                t._slotPointerDirections = new int[] { 0 };            

            return t;
        }

        /// <summary>
        /// Only use 0-1-2-3-4 on your <paramref name="genericSlots"/>.
        /// This function is used when you want your Unit to target a slot without taking into account where the Unit is.
        /// </summary>
        public static BaseCombatTargettingSO GenerateGenericTarget(int[] genericSlots, bool targetAllies = false)
        {
            GenericTargetting_BySlot_Index t = ScriptableObject.CreateInstance<GenericTargetting_BySlot_Index>();

            t.getAllies = targetAllies;
            t.slotPointerDirections = genericSlots;

            return t;
        }

        /// <summary>
        /// Creates Unit targeting with health check.
        /// Use <paramref name="targetAllies"/> to point out if you are targeting opponents or allies.
        /// Use <paramref name="ignoreCastSlot"/> to not include the caster.
        /// Use <paramref name="getAllUnitSlots"/> to include all slots each unit has instead of just one.
        /// Use <paramref name="getWeakestUnit"/> to select between strongest or weakest health units.
        /// </summary>
        public static BaseCombatTargettingSO GenerateUnitTarget_Specific_Health(bool targetAllies = false, bool ignoreCastSlot = false, bool getAllUnitSlots = false, bool getWeakestUnit = false)

        {
            Targetting_ByUnit_Side_Specific_Health t = ScriptableObject.CreateInstance<Targetting_ByUnit_Side_Specific_Health>();
            t.getAllies = targetAllies;
            t.ignoreCastSlot = ignoreCastSlot;
            t.getAllUnitSlots = getAllUnitSlots;
            t.getWeakest = getWeakestUnit;
            return t;
        }
        #endregion
    }
}
