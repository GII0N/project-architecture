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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building2.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building3.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building4.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building5.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building6.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building7.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building8.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building9.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building10.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building11.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building12.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building13.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building14.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building15.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building16.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building17.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building18.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building19.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building20.SetActive(true);
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
        if (wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Building21.SetActive(true);
        }

        else
        {
            NotEnoughError.SetActive(true);
            //StartCoroutine(Wait(2));
        }
    }
}