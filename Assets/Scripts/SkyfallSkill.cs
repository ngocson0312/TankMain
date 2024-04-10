using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyfallSkill : MonoBehaviour
{
    public Transform turretBarrel;
    public GameObject skillPrefab;

    public void Skill()
    {
        GameObject skill = Instantiate(skillPrefab);
        skill.transform.position = turretBarrel.position;
        skill.transform.localRotation = turretBarrel.rotation;
        skill.GetComponent<Skill>().Initialize();
    }
}
