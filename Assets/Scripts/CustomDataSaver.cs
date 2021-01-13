using UnityEngine;

/// <summary>
/// This class use for to save custom bool type data as in PlayerPref
/// </summary>
public class CustomDataSaver : MonoBehaviour
{
    /// <summary>
    /// Returns true if the given key exists in the PlayerPrefs, otherwise return false.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool HasKey(string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Set a single string value for the preference indentified by the given key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SetString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    /// <summary>
    /// Return the value corresponding the key
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string GetString(string name)
    {
        return PlayerPrefs.GetString(name);
    }

    /// <summary>
    /// Set data preference as a bool
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SetBool(string key, bool value)
    {
        PlayerPrefs.SetInt(key, value ? 1 : 0);        
    }

    /// <summary>
    /// Get data preference as bool
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool GetBool(string key)
    {
        return PlayerPrefs.GetInt(key) == 1 ? true : false;
    }

    /// <summary>
    /// Remove all the keys and values from the prefereneces, use this caution 
    /// </summary>
    public static void DeleteAllKey()
    {
        PlayerPrefs.DeleteAll();
    }

    /// <summary>
    /// Remove the given key from PlayerPrefs. If the key does not exits, DeleteKey has no impact.
    /// </summary>
    /// <param name="key"></param>
    public static void DeleteKey(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }
}
