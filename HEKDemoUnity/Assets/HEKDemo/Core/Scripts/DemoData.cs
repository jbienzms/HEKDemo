using System.Linq;
using UnityEngine;

/// <summary>
/// A base class for configuration data that can be used when an application is running in demo mode.
/// </summary>
/// <typeparam name="T">
/// The type the inherited class, which is used in template methods like <see cref="Instance"/>.
/// </typeparam>
/// <remarks>
/// Thanks to Bruno Araujo for this pattern. See
/// <see href="https://baraujo.net/unity3d-making-singletons-from-scriptableobjects-automatically/">here</see>
/// for more information.
/// </remarks>
public abstract class DemoData<T> : ScriptableObject where T : ScriptableObject
{
    #region Member Variables
    static T instance = null;
    #endregion // Member Variables

    #region Public Properties
    /// <summary>
    /// Gets an instance of the demo data if found within the project.
    /// </summary>
    public static T Instance
    {
        get
        {
            if (!instance)
            {
                instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
            }
            return instance;
        }
    }
    #endregion // Public Properties
}
