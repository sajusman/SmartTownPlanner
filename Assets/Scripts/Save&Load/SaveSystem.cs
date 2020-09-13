using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{
    public Button loadButton;
    public Text sceneText;
    public void saveScene()
    {
        if(sceneText.text != null)
        { 
            for (int i = 0; i < ItemDropHandler.toSaveItems.Count; i++)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                string path = Application.persistentDataPath + "Scene#" + sceneText.text + "_" + ItemDropHandler.toSaveItems[i].name + ".item.sav";
                FileStream stream = new FileStream(path, FileMode.Create);
                ItemData data = ItemDropHandler.toSaveItems[i];
                formatter.Serialize(stream, data);
                stream.Close();
            }
        }
    }

    ///public static void loadScene(int number)
    public static void loadScene(string sceneName)
    {
        for(int i=0; i<Inventory.allItems.Count; i++)
        { 
            string path = Application.persistentDataPath + "Scene#" + sceneName + "_" + Inventory.allItems[i].name + ".item.sav";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                ItemData data = formatter.Deserialize(stream) as ItemData;

                Vector3 position = new Vector3(data.position[0], data.position[1], data.position[2]);
                ItemDropHandler.loadItem(Inventory.allItems[i].ItemPrefab, position);
            }

        }
    }
}
