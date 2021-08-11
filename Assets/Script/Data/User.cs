using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "User Name", menuName = "New User", order = 1)]

public class User : SerializedScriptableObject
{
    public string UserName;
    public Sprite UserThamnail;
    public double YearsofExperience;
    public string UserDesignation;

    public Dictionary<SocialMedias, string> SocilaLinks;

    public Dictionary<string, string> CertificationLinks;

    public List<Technologies> Technologies;

}
