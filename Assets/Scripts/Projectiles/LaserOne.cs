/****************************************************************************************
 * Copyright: Jeff Moreau
 * Script: LaserOne.cs
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

namespace TrenchWars
{
    public class LaserOne : MonoBehaviour
    {
        [SerializeField] private Data.ProjectileData mProjectileData = null;

        private void Update()
        {
            transform.position += new Vector3(0, (mProjectileData.GetMovementSpeed * Time.deltaTime), 0);
        }

        private void OnBecameInvisible()
        {
            gameObject.SetActive(false);
        }
    }
}