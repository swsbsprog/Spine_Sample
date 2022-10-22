using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    public SkeletonMecanim scenePlayer;
    public SkeletonGraphic uiPlayer;
    void Start()
    {
        LoadPlayer();
    }
    private void LoadPlayer()
    {
        uiPlayer.skeletonDataAsset = scenePlayer.skeletonDataAsset;
        uiPlayer.AnimationState.SetAnimation(0, "idle", true);
    }

    public void SelectWeapon(string weaponName)
    {
        Skeleton skeleton = uiPlayer.Skeleton;
        ChangeSkin(weaponName, skeleton);
    }

    private static void ChangeSkin(string skinName, Skeleton skeleton)
    {
        var skeletonData = skeleton.Data;
        skeleton.SetSkin(skeletonData.FindSkin(skinName));
        skeleton.SetSlotsToSetupPose();
    }

    private void OnDisable()
    {
        var skinName = uiPlayer.Skeleton.Skin.Name;
        Skeleton skeleton = scenePlayer.Skeleton;
        ChangeSkin(skinName, skeleton);
    }
}
