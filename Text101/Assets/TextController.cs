using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_0, sheets_1, lock_0, cell_mirror, lock_1, freedom};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            state_cell();
        } else if (myState == States.sheets_0)
        {
            state_sheets_0();
        }
        else if (myState == States.sheets_1)
        {
            state_sheets_1();
        }
        else if (myState == States.mirror)
        {
            state_mirror();
        }
        else if (myState == States.lock_0)
        {
            state_lock_0();
        }
        else if (myState == States.cell_mirror)
        {
            state_cell_mirror();
        }
        else if (myState == States.lock_1)
        {
            state_lock_1();
        }
        else if (myState == States.freedom)
        {
            state_freedom();
        }
    }

    void state_cell()
    {
        text.text = "You find yourself come to in a prison cell. " +
                        "You can't remember much, but what you do " +
                        "know is that you need to escape. You look around. " +
                        "The sheets on the bed are tattered and dirty. " +
                        "There's a mirror on the wall and a door nearby " +
                        "which is locked from the outside.\n\n" +
                        "Press S to view Sheets, M to look in the mirror, " +
                        "and L to look at the lock.";
        if (Input.GetKey(KeyCode.S))
        {
            myState = States.sheets_0;        
        } else if (Input.GetKey(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void state_sheets_0()
    {

        text.text = "After ruffling through them you can't seem " +
                    "to find anything significant regarding the " +
                    "sheets.\n\nPress R to Return to roaming the cell.";
        if (Input.GetKey(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_sheets_1()
    {

        text.text = "After ruffling through them you can't seem " +
                    "to find anything significant regarding the " +
                    "sheets.\n\nPress R to Return to roaming the cell.";
        if (Input.GetKey(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void state_mirror()
    {

        text.text = "A small handheld mirror lies on the ground. " +
                    "Perhaps this could be useful.\n\n" +
                    "Press T to take the mirror or R to return to roaming.";
        if (Input.GetKey(KeyCode.R))
        {
            myState = States.cell;
        } else if (Input.GetKey(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }

    void state_lock_0()
    {
        text.text = "The lock is attached to a door made of solid steel bars. " + 
                    "It's a keypad, but you don't know the combination. Perhaps if " +
                    "you could see into the next room better there'd be something " + 
                    "could help you. \n\n Press R to return to roaming.";
        if (Input.GetKey(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_cell_mirror()
    {
        text.text = "You return to roaming your cell but now you are " +
                    "equipped with the handheld mirror. You look around " +
                    "to determine what's next.\n\nPress S to view your " + 
                    "sheets or press L to go to the lock.";
        if (Input.GetKey(KeyCode.S))
        {
            myState = States.sheets_1;
        } else if (Input.GetKey(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void state_lock_1()
    {
        text.text = "You approach the lock again with the mirror in hand. " +
                    "You slip the mirror between the bars of the door and " +
                    "angle it about, looking for anything that can help you. " +
                    "You spy a small piece of parchments crumpled on the floor " +
                    "near the desk of a guard. Upon the parchment is a series " + 
                    "of numbers reading: 9 - 7 - 2 - 7. Hastily, you plug them " +
                    "into the keypad and hear the latch unhitch.\n\nPress P to " + 
                    "proceed through the doorway.";
        if (Input.GetKey(KeyCode.P))
        {
            myState = States.freedom;
        }
    }

    void state_freedom()
    {
        text.text = "The prison is abandoned. Your feet pad through the " +
            "halls of the building as you seek the exit. Your memory " +
            "begins to come into focus. They were all evacuated and " +
            "you were left behind. But now, with no one around you " +
            "are able to make your escape unseen. Finally, you reach " +
            "the door to the outside. A blast of fresh air fills your lungs as " +
            "you step out into the sun, leaving behind the" +
            "damp darkness of the prison.\n\nYou made it.\n\n" +
            "Press S to Start the game over again.";
        if (Input.GetKey(KeyCode.S))
        {
            myState = States.cell;
        }
    }
}
