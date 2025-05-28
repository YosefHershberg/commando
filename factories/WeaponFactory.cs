using System;
using System.Collections.Generic;
using OOP.weapon;
using OOP.Utils;

namespace OOP
{
    class WeaponFactory
    {
        //here we save the type of weapon and the function that creates it
        private Dictionary<WeaponType, Func<object>> weaponRegistry = new Dictionary<WeaponType, Func<object>>();

        public WeaponFactory()
        {
            RegisterWeapon(WeaponType.M16, () => new M16());
            RegisterWeapon(WeaponType.AK47, () => new AK47());
            RegisterWeapon(WeaponType.Rock, () => new Rock("Rock", 2.0, "Gray"));
            RegisterWeapon(WeaponType.Knife, () => new Knife("Knife", "Steel", "DefaultMaker", "Silver", 0.5));
        }

        // This is where open closed principle
        // NOTE: in order to register a new weapon u must add it to the WeaponType enum
        public void RegisterWeapon(WeaponType weaponType, Func<object> creator)
        {
            weaponRegistry[weaponType] = creator;
        }

        public object CreateWeapon(WeaponType weaponType)
        {
            if (weaponRegistry.ContainsKey(weaponType))
                return weaponRegistry[weaponType]();
            throw new ArgumentException($"Weapon type '{weaponType}' not registered.");
        }
    }
}