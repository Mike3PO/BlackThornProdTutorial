using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunctionsAndArrays : MonoBehaviour
{

    public TMP_Text spellText;
    public SpriteRenderer spellRend;
    public string[] spellNames;
    public Sprite[] spellSprites;
    public int spellIndex;

    // Start is called before the first frame update
    void Start()
    {
        print("Hey There");
        print("Wassup!");
        print("Final Message");
    }

    // Update is called once per frame
    void Update()
    {
        ViewSpell(spellNames[spellIndex < spellNames.Length && spellIndex > 0 ? spellIndex : 0], spellSprites[spellIndex < spellSprites.Length && spellIndex > 0 ? spellIndex : 0]);
    }

    void ViewSpell(string spellName, Sprite spellSprite){
        spellText.text = spellName;
        spellRend.sprite = spellSprite;
    }
}
