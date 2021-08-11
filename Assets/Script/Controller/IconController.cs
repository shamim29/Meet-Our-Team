using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconController : SerializedMonoBehaviour
{
    public static IconController instance;

    public Dictionary<SocialMedias, Sprite> SocialIcons;
    public Dictionary<Technologies, Sprite> TechnologiesIcons;

    private void Awake()
    {
        instance = this;
    }

    public Sprite GetIcon(SocialMedias socialMedia)
    {
        return SocialIcons[socialMedia];
    }

    public Sprite GetIcon(Technologies technologies)
    {
        return TechnologiesIcons[technologies];
    }



}
