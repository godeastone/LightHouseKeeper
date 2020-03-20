using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacilityManager : MonoBehaviour
{
    public DatabaseManager Data;

    public int Max_Light;
    public int Max_Glass;
    public int Max_Energy;

    public Button btn_L1;
    public Button btn_L2;
    public Button btn_L3;
    public Button btn_L4;
    public Button btn_L5;
    public Button btn_L6;
    public Button btn_L7;
    public Button btn_L8;
    public Button btn_L9;
    public Button btn_L10;
    public Button btn_G1;
    public Button btn_G2;
    public Button btn_G3;
    public Button btn_G4;
    public Button btn_G5;
    public Button btn_G6;
    public Button btn_G7;
    public Button btn_G8;
    public Button btn_G9;
    public Button btn_G10;
    public Button btn_E1;
    public Button btn_E2;
    public Button btn_E3;
    public Button btn_E4;
    public Button btn_E5;
    public Button btn_E6;
    public Button btn_E7;
    public Button btn_E8;
    public Button btn_E9;
    public Button btn_E10;



    public void myeong1Button()
    {
        Data.facility_light = 1;
        if (Max_Light == 1)
        {
            Max_Light = 2;
        }
        CheckLevel();
    }
    public void myeong2Button()
    {
        Data.facility_light = 2;
        if (Max_Light == 2)
        {
            Max_Light = 3;
        }
        CheckLevel();
    }
    public void myeong3Button()
    {
        Data.facility_light = 3;
        if (Max_Light == 3)
        {
            Max_Light = 4;
        }
        CheckLevel();
    }
    public void myeong4Button()
    {
        Data.facility_light = 4;
        if (Max_Light == 4)
        {
            Max_Light = 5;
        }
        CheckLevel();
    }
    public void myeong5Button()
    {
        Data.facility_light = 5;
        if (Max_Light == 5)
        {
            Max_Light = 6;
        }
        CheckLevel();
    }
    public void myeong6Button()
    {
        Data.facility_light = 6;
        if (Max_Light == 6)
        {
            Max_Light = 7;
        }
        CheckLevel();
    }
    public void myeong7Button()
    {
        Data.facility_light = 7;
        if (Max_Light == 7)
        {
            Max_Light = 8;
        }
        CheckLevel();
    }
    public void myeong8Button()
    {
        Data.facility_light = 8;
        if (Max_Light == 8)
        {
            Max_Light = 9;
        }
        CheckLevel();
    }
    public void myeong9Button()
    {
        Data.facility_light = 9;
        if (Max_Light == 9)
        {
            Max_Light = 10;
        }
        CheckLevel();
    }
    public void myeong10Button()
    {
        Data.facility_light = 10;
        CheckLevel();
    }

    // /////////////////////////////////////

    public void deung1Button()
    {
        Data.facility_glass = 1;
        if (Max_Glass == 1)
        {
            Max_Glass = 2;
        }
        CheckLevel();
    }
    public void deung2Button()
    {
        Data.facility_glass = 2;
        if (Max_Glass == 2)
        {
            Max_Glass = 3;
        }
        CheckLevel();
    }
    public void deung3Button()
    {
        Data.facility_glass = 3;
        if (Max_Glass == 3)
        {
            Max_Glass = 4;
        }
        CheckLevel();
    }
    public void deung4Button()
    {
        Data.facility_glass = 4;
        if (Max_Glass == 4)
        {
            Max_Glass = 5;
        }
        CheckLevel();
    }
    public void deung5Button()
    {
        Data.facility_glass = 5;
        if (Max_Glass == 5)
        {
            Max_Glass = 6;
        }
        CheckLevel();
    }
    public void deung6Button()
    {
        Data.facility_glass = 6;
        if (Max_Glass == 6)
        {
            Max_Glass = 7;
        }
        CheckLevel();
    }
    public void deung7Button()
    {
        Data.facility_glass = 7;
        if (Max_Glass == 7)
        {
            Max_Glass = 8;
        }
        CheckLevel();
    }
    public void deung8Button()
    {
        Data.facility_glass = 8;
        if (Max_Glass == 8)
        {
            Max_Glass = 9;
        }
        CheckLevel();
    }
    public void deung9Button()
    {
        Data.facility_glass = 9;
        if (Max_Glass == 9)
        {
            Max_Glass = 10;
        }
        CheckLevel();
    }
    public void deung10Button()
    {
        Data.facility_glass = 10;
        CheckLevel();
    }

    // ///////////////////

    public void jeon1Button()
    {
        Data.facillity_energy = 1;
        if (Max_Energy == 1)
        {
            Max_Energy = 2;
        }
        CheckLevel();
    }
    public void jeon2Button()
    {
        Data.facillity_energy = 2;
        if (Max_Energy == 2)
        {
            Max_Energy = 3;
        }
        CheckLevel();
    }
    public void jeon3Button()
    {
        Data.facillity_energy = 3;
        if (Max_Energy == 3)
        {
            Max_Energy = 4;
        }
        CheckLevel();
    }
    public void jeon4Button()
    {
        Data.facillity_energy = 4;
        if (Max_Energy == 4)
        {
            Max_Energy = 5;
        }
        CheckLevel();
    }
    public void jeon5Button()
    {
        Data.facillity_energy = 5;
        if (Max_Energy == 5)
        {
            Max_Energy = 6;
        }
        CheckLevel();
    }
    public void jeon6Button()
    {
        Data.facillity_energy = 6;
        if (Max_Energy == 6)
        {
            Max_Energy = 7;
        }
        CheckLevel();
    }
    public void jeon7Button()
    {
        Data.facillity_energy = 7;
        if (Max_Energy == 7)
        {
            Max_Energy = 8;
        }
        CheckLevel();
    }
    public void jeon8Button()
    {
        Data.facillity_energy = 8;
        if (Max_Energy == 8)
        {
            Max_Energy = 9;
        }
        CheckLevel();
    }
    public void jeon9Button()
    {
        Data.facillity_energy = 9;
        if (Max_Energy == 9)
        {
            Max_Energy = 10;
        }
        CheckLevel();
    }
    public void jeon10Button()
    {
        Data.facillity_energy = 10;
        CheckLevel();
    }

    private void CheckLevel()
    {
        switch (Max_Light)
        {
            case 1:
                btn_L2.interactable = false;
                btn_L3.interactable = false;
                btn_L4.interactable = false;
                btn_L5.interactable = false;
                btn_L6.interactable = false;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 2:
                btn_L2.interactable = true;
                btn_L3.interactable = false;
                btn_L4.interactable = false;
                btn_L5.interactable = false;
                btn_L6.interactable = false;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 3:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = false;
                btn_L5.interactable = false;
                btn_L6.interactable = false;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 4:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = false;
                btn_L6.interactable = false;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 5:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = false;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 6:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = true;
                btn_L7.interactable = false;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 7:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = true;
                btn_L7.interactable = true;
                btn_L8.interactable = false;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 8:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = true;
                btn_L7.interactable = true;
                btn_L8.interactable = true;
                btn_L9.interactable = false;
                btn_L10.interactable = false;
                break;
            case 9:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = true;
                btn_L7.interactable = true;
                btn_L8.interactable = true;
                btn_L9.interactable = true;
                btn_L10.interactable = false;
                break;
            case 10:
                btn_L2.interactable = true;
                btn_L3.interactable = true;
                btn_L4.interactable = true;
                btn_L5.interactable = true;
                btn_L6.interactable = true;
                btn_L7.interactable = true;
                btn_L8.interactable = true;
                btn_L9.interactable = true;
                btn_L10.interactable = true;
                break;
        }

        switch (Max_Glass)
        {
            case 1:
                btn_G2.interactable = false;
                btn_G3.interactable = false;
                btn_G4.interactable = false;
                btn_G5.interactable = false;
                btn_G6.interactable = false;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 2:
                btn_G2.interactable = true;
                btn_G3.interactable = false;
                btn_G4.interactable = false;
                btn_G5.interactable = false;
                btn_G6.interactable = false;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 3:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = false;
                btn_G5.interactable = false;
                btn_G6.interactable = false;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 4:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = false;
                btn_G6.interactable = false;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 5:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = false;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 6:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = true;
                btn_G7.interactable = false;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 7:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = true;
                btn_G7.interactable = true;
                btn_G8.interactable = false;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 8:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = true;
                btn_G7.interactable = true;
                btn_G8.interactable = true;
                btn_G9.interactable = false;
                btn_G10.interactable = false;
                break;
            case 9:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = true;
                btn_G7.interactable = true;
                btn_G8.interactable = true;
                btn_G9.interactable = true;
                btn_G10.interactable = false;
                break;
            case 10:
                btn_G2.interactable = true;
                btn_G3.interactable = true;
                btn_G4.interactable = true;
                btn_G5.interactable = true;
                btn_G6.interactable = true;
                btn_G7.interactable = true;
                btn_G8.interactable = true;
                btn_G9.interactable = true;
                btn_G10.interactable = true;
                break;

        }

        switch (Max_Energy)
        {
            case 1:
                btn_E2.interactable = false;
                btn_E3.interactable = false;
                btn_E4.interactable = false;
                btn_E5.interactable = false;
                btn_E6.interactable = false;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 2:
                btn_E2.interactable = true;
                btn_E3.interactable = false;
                btn_E4.interactable = false;
                btn_E5.interactable = false;
                btn_E6.interactable = false;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 3:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = false;
                btn_E5.interactable = false;
                btn_E6.interactable = false;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 4:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = false;
                btn_E6.interactable = false;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 5:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = false;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 6:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = true;
                btn_E7.interactable = false;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 7:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = true;
                btn_E7.interactable = true;
                btn_E8.interactable = false;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 8:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = true;
                btn_E7.interactable = true;
                btn_E8.interactable = true;
                btn_E9.interactable = false;
                btn_E10.interactable = false;
                break;
            case 9:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = true;
                btn_E7.interactable = true;
                btn_E8.interactable = true;
                btn_E9.interactable = true;
                btn_E10.interactable = false;
                break;
            case 10:
                btn_E2.interactable = true;
                btn_E3.interactable = true;
                btn_E4.interactable = true;
                btn_E5.interactable = true;
                btn_E6.interactable = true;
                btn_E7.interactable = true;
                btn_E8.interactable = true;
                btn_E9.interactable = true;
                btn_E10.interactable = true;
                break;

        }
    }
    
        private void Start()
    {
        CheckLevel();
    }
}
