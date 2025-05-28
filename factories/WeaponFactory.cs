using System;
using System.Collections.Generic;
using OOP.weapon;

namespace OOP
{
    class WeaponFactory
    {
        //here we save the type of weapon and the function that creates it
        private Dictionary<string, Func<object>> weaponRegistry = new Dictionary<string, Func<object>>();

        public WeaponFactory()
        {
            RegisterWeapon("M16", () => new M16());
            RegisterWeapon("AK47", () => new AK47());
            RegisterWeapon("Rock", () => new Rock("Rock", 2.0, "Gray"));
            RegisterWeapon("Knife", () => new Knife("Knife", "Steel", "DefaultMaker", "Silver", 0.5));
        }

        // This is where open closed principle
        public void RegisterWeapon(string weaponType, Func<object> creator)
        {
            weaponRegistry[weaponType] = creator;
        }

        public object CreateWeapon(string weaponType)
        {
            if (weaponRegistry.ContainsKey(weaponType))
                return weaponRegistry[weaponType]();
            throw new ArgumentException($"Weapon type '{weaponType}' not registered.");
        }
    }
}