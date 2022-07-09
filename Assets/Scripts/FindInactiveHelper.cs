using UnityEngine;

public static class FindInactiveHelper
{
    // Finds gameObject with given name as child of given active parent object
    public static GameObject FindObjectByName(this GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }

    // Finds gameObjects with given name as children of given active parent object
    public static GameObject[] FindObjectsByName(this GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        int size = 0;
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                size++;
            }
        }
        GameObject[] gameObjects = new GameObject[size];
        int i = 0;
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                gameObjects[i] = t.gameObject;
                i++;
            }
        }
        if (size != 0)
        {
            return gameObjects;
        }
        else
        {
            return null;
        }
    }

    // Finds gameObject with given tag as child of given active parent object
    public static GameObject FindObjectByTag(this GameObject parent, string tag)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.tag == tag)
            {
                return t.gameObject;
            }
        }
        return null;
    }

    // Finds all gameObjects with given tag as children of given active parent object
    public static GameObject[] FindObjectsByTag(this GameObject parent, string tag)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        int size = 0;
        foreach (Transform t in trs)
        {
            if (t.tag == tag)
            {
                size++;
            }
        }
        GameObject[] gameObjects = new GameObject[size];
        int i = 0;
        foreach (Transform t in trs)
        {
            if (t.tag == tag)
            {
                gameObjects[i] = t.gameObject;
                i++;
            }
        }
        if (size != 0)
        {
            return gameObjects;
        }
        else
        {
            return null;
        }
    }

}
