using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "User Name", menuName = "New User", order = 1)]

public class User : SerializedScriptableObject
{
    public string UserExperience;
    public string UserName;
    public string UserDesignation;
    public Sprite UserProfile;

    public Dictionary<SocialMedias, string> SocilaLinks;
    
    public string UserQuotes;

    public List<Technologies> Technologies;


    public Dictionary<string, string> CertificationLinks;

    

}
