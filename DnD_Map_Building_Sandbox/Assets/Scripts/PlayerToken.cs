using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerToken : NetworkBehaviour
{
    public GameObject m_PlayerToken;

    public Material[] m_PlayerClass;
    public NetworkManager m_NetworkManager;
    string[] Classes;

    // Start is called before the first frame update
    void Start()
    {
        Classes = new string[] { "Barbarian",
                                 "Bard",
                                 "Blood Hunter",
                                 "Cleric",
                                 "Druid",
                                 "Fighter",
                                 "Monk",
                                 "Paladin",
                                 "Ranger",
                                 "Rogue",
                                 "Sorcerer",
                                 "Warlock",
                                 "Wizard"};
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetPlayerClassBarbarian()
    {
        if (m_PlayerToken != null)
        {            
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[0];
        }
    }

    public void SetPlayerClassBard()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[1];
        }
    }

    public void SetPlayerClassBloodHunter()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[2];
        }
    }

    public void SetPlayerClassCleric()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[3];
        }
    }

    public void SetPlayerClassDruid()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[4];
        }
    }

    public void SetPlayerClassFigher()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[5];
        }
    }

    public void SetPlayerClassMonk()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[6];
        }
    }

    public void SetPlayerClassPaladin()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[7];
        }
    }

    public void SetPlayerClassRanger()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[8];
        }
    }

    public void SetPlayerClassRogue()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[9];
        }
    }

    public void SetPlayerClassSorcerer()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[10];
        }
    }

    public void SetPlayerClassWarlock()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[11];
        }
    }

    

    public void SetPlayerClassWizard()
    {
        if (m_PlayerToken != null)
        {
            GameObject token = Instantiate(m_PlayerToken, new Vector3(0.0f, 0.125f, 0.0f), Quaternion.AngleAxis(180.0f, Vector3.up));
            token.GetComponent<Renderer>().sharedMaterial = m_PlayerClass[12];
        }
    }
}
