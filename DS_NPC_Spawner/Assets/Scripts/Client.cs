using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.VillagersSpeak();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            m_SpawnerNPC.SpellBeggar();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            m_SpawnerNPC.SpellFarmer();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            m_SpawnerNPC.SpellShopowner();
        }
    }
}
