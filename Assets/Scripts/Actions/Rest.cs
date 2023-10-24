using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rest : GAction {

    public override bool PrePerform() {

        return true;
    }

    public override bool PostPerform() {
        beliefs.states.Remove("exhausted");
        return true;
    }
}