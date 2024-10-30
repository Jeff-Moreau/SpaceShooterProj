/****************************************************************************************
 * Copyright: Jeff Moreau
 * Script: ProjectileSO.cs
 * Date Created: October 20, 2023
 * Created By: Jeff Moreau
 * Used On:
 * Description:
 ****************************************************************************************
 * Modified By: Jeff Moreau
 * Date Last Modified: October 20, 2024
 ****************************************************************************************
 * TODO:
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace TrenchWars.Data
{
    [CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/New ProjectileData")]
    public class ProjectileData : ScriptableObject
    {
        //VARIABLES
        #region Inspector Variable Declarations and Initializations

        [SerializeField] private float MovementSpeed = 0.0f;
        [SerializeField] private float Damage = 1.0f;

        #endregion

        //GETTERS
        #region Accessors/Getters

        public float GetDamage => Damage;
        public float GetMovementSpeed => MovementSpeed;

        #endregion
    }
}