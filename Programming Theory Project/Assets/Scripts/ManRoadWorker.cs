using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManRoadWorker : Character
{
    void Update()
    {
        RotateCharacter();
    }
    private void OnMouseDown()
    {
        ChooseCharacter();
    }
    public override string NameText()
    {
        return "Name: Lorenzo";
    }
    public override string ProfessionText()
    {
        return "Profession: RoadWorker Man";
    }
}
