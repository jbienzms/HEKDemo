using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides demo configuration data which is specific to this sample application.
/// </summary>
/// <remarks>
/// <para>
/// An instance of this class can be added to the project by right-clicking on the Assets folder
/// and choosing Create -> Demo -> My Demo Data. If an instance has been added to the project, the
/// <see cref="Instance"/> property will return the data configured in the inspector. If an
/// instance has <i>not</i> been added to the project, the <see cref="Instance"/> property will
/// return < see langword = "null" />.
/// </para>
/// <para>
/// <b>IMPORTANT:</b> The pattern <c>*Demo Data.*</c> has been ignored in this repository, which
/// means that configuration data will exist on your local machine only. This is intentional so
/// that sensitive information like API keys are not checked into source control.
/// </para>
/// </remarks>
[CreateAssetMenu(menuName = "Demo/My Demo Data")]
public class MyDemoData : DemoData<MyDemoData>
{
    /// <summary>
    /// The user name to use for the demo.
    /// </summary>
    public string UserName;

    /// <summary>
    /// The password to use for the demo.
    /// </summary>
    public string Password;

    /// <summary>
    /// The Azure Spatial Anchors account ID.
    /// </summary>
    public string ASAId;

    /// <summary>
    /// The Azure Spatial Anchors account Key.
    /// </summary>
    public string ASAKey;
}
