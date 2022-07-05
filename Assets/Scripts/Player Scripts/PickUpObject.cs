using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpObject : MonoBehaviour
{
    public int wood;
    public int stone;
    public int metal;

    public GameObject NotEnoughError;
    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public GameObject Building4;
    public GameObject Building5;
    public GameObject Building6;
    public GameObject Building7;
    public GameObject Building8;
    public GameObject Building9;
    public GameObject Building10;
    public GameObject Building11;
    public GameObject Building12;
    public GameObject Building13;
    public GameObject Building14;
    public GameObject Building15;
    public GameObject Building16;
    public GameObject Building17;
    public GameObject Building18;
    public GameObject Building19;
    public GameObject Building20;
    public GameObject Building21;
    public GameObject Ruin1;
    public GameObject Ruin2;
    public GameObject Ruin3;
    public GameObject Ruin4;
    public GameObject Ruin5;
    public GameObject Ruin6;
    public GameObject Ruin7;
    public GameObject Ruin8;
    public GameObject Ruin9;
    public GameObject Ruin10;
    public GameObject Ruin11;
    public GameObject Ruin12;
    public GameObject Ruin13;
    public GameObject Ruin14;
    public GameObject Ruin15;
    public GameObject Ruin16;
    public GameObject Ruin17;
    public GameObject Ruin18;
    public GameObject Ruin19;
    public GameObject Ruin20;
    public GameObject Ruin21;

    public TextMeshProUGUI woodCounter;
    public TextMeshProUGUI woodCounter1;
    public TextMeshProUGUI stoneCounter;
    public TextMeshProUGUI stoneCounter1;
    public TextMeshProUGUI metalCounter;
    public TextMeshProUGUI metalCounter1;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "Wood")
        {
            wood++;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Stone")
        {
            stone++;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Metal")
        {
            metal++;
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Destroy(collider.gameObject);
        }
    }

    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem1()
    {
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building1.SetActive(true);
            Ruin1.SetActive(false);

        }
        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem2()
    {
        if (wood >= 2 && stone >= 1)
        {
            wood -= 2;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building2.SetActive(true);
            Ruin2.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem3()
    {
        if (wood >= 2 && stone >= 2)
        {
            wood -= 2;
            stone -= 2;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building3.SetActive(true);
            Ruin3.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem4()
    {
        if (wood >= 3 && stone >= 2)
        {
            wood -= 3;
            stone -= 2;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building4.SetActive(true);
            Ruin4.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------\
    public void BuyItem5()
    {
        if (wood >= 3 && stone >= 3)
        {
            wood -= 3;
            stone -= 3;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building5.SetActive(true);
            Ruin5.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem6()
    {
        if (wood >= 4 && stone >= 3)
        {
            wood -= 4;
            stone -= 3;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building6.SetActive(true);
            Ruin6.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem7()
    {
        if (wood >= 4 && metal >= 1)
        {
            wood -= 4;
            metal -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building7.SetActive(true);
            Ruin7.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem8()
    {
        if (wood >= 5 && metal >= 1)
        {
            wood -= 5;
            metal -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building8.SetActive(true);
            Ruin8.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem9()
    {
        if (wood >= 5 && metal >= 2)
        {
            wood -= 5;
            metal -= 2;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building9.SetActive(true);
            Ruin9.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem10()
    {
        if (wood >= 6 && metal >= 2)
        {
            wood -= 6;
            metal -= 2;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building10.SetActive(true);
            Ruin10.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem11()
    {
        if (wood >= 6 && metal >= 3)
        {
            wood -= 6;
            metal -= 3;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building11.SetActive(true);
            Ruin11.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem12()
    {
        if (wood >= 7 && metal >= 3)
        {
            wood -= 7;
            metal -= 3;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building12.SetActive(true);
            Ruin12.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem13()
    {
        if (stone >= 4 && metal >= 4)
        {
            stone -= 4;
            metal -= 4;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building13.SetActive(true);
            Ruin13.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem14()
    {
        if (stone >= 5 && metal >= 4)
        {
            stone -= 5;
            metal -= 4;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building14.SetActive(true);
            Ruin14.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem15()
    {
        if (stone >= 5 && metal >= 5)
        {
            stone -= 5;
            metal -= 5;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building15.SetActive(true);
            Ruin15.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem16()
    {
        if (stone >= 6 && metal >= 5)
        {
            stone -= 6;
            metal -= 5;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building16.SetActive(true);
            Ruin16.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem17()
    {
        if (stone >= 6 && metal >= 6)
        {
            stone -= 6;
            metal -= 6;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building17.SetActive(true);
            Ruin17.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem18()
    {
        if (stone >= 7 && metal >= 6)
        {
            stone -= 7;
            metal -= 6;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building18.SetActive(true);
            Ruin18.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem19()
    {
        if (stone >= 7 && metal >= 7)
        {
            stone -= 7;
            metal -= 7;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building19.SetActive(true);
            Ruin19.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem20()
    {
        if (stone >= 8 && metal >= 7)
        {
            stone -= 8;
            metal -= 7;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building20.SetActive(true);
            Ruin20.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem21()
    {
        if (stone >= 8 && metal >= 8)
        {
            stone -= 8;
            metal -= 8;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building21.SetActive(true);
            Ruin21.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
        //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem22()
    {
        if (stone >= 8 && metal >= 8)
        {
            stone -= 8;
            metal -= 8;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building21.SetActive(true);
            Ruin21.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
        //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem23()
    {
        if (stone >= 8 && metal >= 8)
        {
            stone -= 8;
            metal -= 8;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building21.SetActive(true);
            Ruin21.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
        //----------------------------------------------------------------------------------------------------------------------
    public void BuyItem24()
    {
        if (stone >= 8 && metal >= 8)
        {
            stone -= 8;
            metal -= 8;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Building21.SetActive(true);
            Ruin21.SetActive(false);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
}