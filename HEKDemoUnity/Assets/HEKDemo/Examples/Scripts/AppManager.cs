using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A simple "Manager" class that shows how the sample data would be used by an application.
/// </summary>
public class AppManager : MonoBehaviour
{
    #region Member Variables
    private MyDemoData demoData;
    #endregion // Member Variables

    #region Internal Methods
    /// <summary>
    /// Loads configuration data for the application.
    /// </summary>
    private void LoadConfiguration()
    {
        // If there's a demo config in the project, get a reference to it
        demoData = MyDemoData.Instance;

        // Use demo config or regular code path?
        if (demoData != null)
        {
            Debug.Log($"Demo configuration found. User Name: {demoData.UserName}");
        }
        else
        {
            Debug.Log("No demo configuration found. Using regular app flow.");
        }
    }
    #endregion // Internal Methods


    #region Unity Overrides
    // Start is called before the first frame update
    void Start()
    {
        LoadConfiguration();
    }
    #endregion // Unity Overrides
}
