using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaveLoadPositionMono : MonoBehaviour
{

    public Transform m_whatToSave;

    public SaveData m_saveData;

    [System.Serializable]
    public class SaveData
    {
        public Vector3 m_position;
        public Quaternion m_rotation;
    }

    public string m_guid;
    private void Reset()
    {
        m_guid = System.Guid.NewGuid().ToString();
    }
    private void OnEnable()
    {
      string json =  PlayerPrefs.GetString(m_guid);
      if(json != "")
        {
            m_saveData = JsonUtility.FromJson<SaveData>(json);
            m_whatToSave.position = m_saveData.m_position;
            m_whatToSave.rotation = m_saveData.m_rotation;
        }
    }
    private void OnDisable()
    {
        m_saveData= new SaveData();
        m_saveData.m_position = m_whatToSave.position;
        m_saveData.m_rotation = m_whatToSave.rotation;
        PlayerPrefs.SetString(m_guid, JsonUtility.ToJson(m_saveData));
    }

}
