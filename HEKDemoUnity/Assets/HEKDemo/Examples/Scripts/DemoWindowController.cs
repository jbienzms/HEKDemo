using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Used by the Demo Window prefab to update stats on the window.
/// </summary>
public class DemoWindowController : MonoBehaviour
{
    #region Member Variables
    private MyDemoData demoData;
    #endregion // Member Variables

    #region Unity Inspector Fields
    [SerializeField]
    private TextMeshProUGUI demoStatusText;

    [SerializeField]
    private TextMeshProUGUI unityAppVersionText;

    [SerializeField]
    private TextMeshProUGUI unityRuntimeText;

    [SerializeField]
    private TextMeshProUGUI userInfoText;

    [SerializeField]
    private TextMeshProUGUI uwpAppVersionText;
    #endregion // Unity Inspector Fields

    /// <summary>
    /// Loads stats UI controls.
    /// </summary>
    private void LoadUI()
    {
        // Load versions
        unityAppVersionText.text = Application.version;
        unityRuntimeText.text = Application.unityVersion;
        #if WINDOWS_UWP
        var ver = Windows.ApplicationModel.Package.Current.Id.Version;
        uwpAppVersionText.text = $"{ver.Build}.{ver.Major}.{ver.Minor}.{ver.Revision}";
        #else
        uwpAppVersionText.text = "(Not UWP Build)";
        #endif

        // Load demo status
        demoData = MyDemoData.Instance;
        demoStatusText.text = (demoData != null) ? "Demo Mode" : "Normal Mode";
        userInfoText.text = (demoData != null) ? demoData.UserName : "Must sign in";
    }

    #region Unity Overrides
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    protected virtual void Start()
    {
        LoadUI();
    }
    #endregion // Unity Overrides
}
