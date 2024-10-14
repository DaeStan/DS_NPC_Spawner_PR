using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    public INPC m_Farmer;
    public INPC m_Beggar;
    public INPC m_Shopowner;
    public INPC m_Witch;
    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Witch = m_Factory.GetNPC(NPCType.Witch);
    }

    public void VillagersSpeak()
    {
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Beggar.Speak();

        Debug.Log("Press F, G, or H to cast spell");
    }

    public void SpellBeggar()
    {
        m_Witch.Speak();
        m_Beggar.Spell();
    }

    public void SpellShopowner()
    {
        m_Witch.Speak();
        m_Shopowner.Spell();
    }

    public void SpellFarmer()
    {
        m_Witch.Speak();
        m_Farmer.Spell();
    }
}
