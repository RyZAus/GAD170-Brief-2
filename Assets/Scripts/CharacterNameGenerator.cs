using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Generate Names -
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
 
    [Header("Possible first names")]
    public List<string> firstNames; // These appear in the inspector, you should be assigning names to these in the inspector.
    [Header("Possible last names")]
    public List<string> lastNames;
    [Header("Possible nicknames")]
    public List<string> nicknames;
    [Header("Possible adjectives to describe the character")]
    public List<string> descriptors;

    /// <summary>
    /// Returns an Array of Character Names based on the number of namesNeeded.
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    /// scope / return (name) / name / (imput)
    public CharacterName[] GenerateNames(int namesNeeded)
    {
        Debug.LogWarning("CharacterNameGenerator called, it needs to fill out the names array with unique randomly constructed character names");
        //return name /  / number of arrays
        CharacterName[] names = new CharacterName[namesNeeded]; 
        CharacterName emptyName = new CharacterName(string.Empty, string.Empty, string.Empty, string.Empty);
        //CharacterName emptyName = new CharacterName(string.firstNames[i], string.;astNames[i], string.nickNames[i], string.descriptos[i]);

        //for loop / initialise i = 0 / condition i < names.Length / increment i++
        for (int i = 0; i < names.Length; i++)
        {
            //creates a name from the list randomly for each name and assigns it to firstName, lastName, nickname, and descriptor respectively
            emptyName.firstName = firstNames[Random.Range(0, firstNames.Count)];
            emptyName.lastName = lastNames[Random.Range(0, lastNames.Count)];
            emptyName.nickname = nicknames[Random.Range(0, nicknames.Count)];
            emptyName.descriptor = descriptors[Random.Range(0, descriptors.Count)];
            //store emptyName to array value i Eg. names[0] = john sorrow narrow slow
            names[i] = emptyName;
        }

        //Returns an array of names that we just created.
        return names;

        //array loop
    }
}