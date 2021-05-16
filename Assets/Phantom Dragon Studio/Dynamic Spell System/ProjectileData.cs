﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile Data", menuName = "New Projectile Data", order = 0)]

[System.Serializable]
public class ProjectileData : ScriptableObject
{
    [SerializeField] new string name;
    [SerializeField] Sprite icon;
    [SerializeField] GameObject sfx;
   // [SerializeField] private Element element;
    [SerializeField] private float damage;
    [SerializeField] private float lifetime;
    [SerializeField] private float speed;

    public float Speed { get => speed; private set => speed = value; }
    public float Lifetime { get => lifetime; private set => lifetime = value; }
    public float Damage { get => damage; private set => damage = value; }
    //public Element Element { get => element; private set => element = value; }
    public GameObject SFX { get => sfx; private set => sfx = value; }
    public Sprite Icon { get => icon; private set => icon = value; }
    public string Name { get => name; private set => name = value; }
}
