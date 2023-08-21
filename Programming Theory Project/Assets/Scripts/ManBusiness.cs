using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManBusiness : Character
{
    // Update is called once per frame
    void Update()
    {
        RotateCharacter();
    }

    private void OnMouseDown()
    {
        ChooseCharacter();
    }

    //POLYMORPHISM
    //INHERITANCE
    public override string NameText()
    {
        return "Name: Max";
    }

    public override string ProfessionText()
    {
        return "Profession: Business Man";
    }
}
