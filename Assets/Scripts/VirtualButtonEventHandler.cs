/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/

using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Vuforia;
using DG.Tweening;

/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to swap materials for the teapot model depending on what 
/// virtual button has been pressed.
/// </summary>
public class VirtualButtonEventHandler : MonoBehaviour,
                                         IVirtualButtonEventHandler
{
    #region PUBLIC_MEMBER_VARIABLES

    /// <summary>
    /// The materials that will be set for the teapot model
    /// </summary>
//    public Material[] m_TeapotMaterials;
	public GameObject bird_go;
	private int var;


    #endregion // PUBLIC_MEMBER_VARIABLES



    #region PRIVATE_MEMBER_VARIABLES
    
//    private GameObject mTeapot;
//    private List<Material> mActiveMaterials;

    #endregion // PRIVATE_MEMBER_VARIABLES



    #region UNITY_MONOBEHAVIOUR_METHODS

	void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

    }
	
    #endregion // UNITY_MONOBEHAVIOUR_METHODS


    #region PUBLIC_METHODS
    
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        //Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);

		if( vb.VirtualButtonName == "VirtualButton" )
		{
			Debug.Log ( "teste" );
			var = 1;
			bird_go.AddComponent<MyAnimation>();
		}

    }


    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
//		if( vb.VirtualButtonName == "VirtualButton" )
//		{
//			Debug.Log ( "tirei" );
////			bird_go.AddComponent<MyAnimation>();
//		}

    }
	
    #endregion // PUBLIC_METHODS
}
