using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    public static PersistentManagerScript Instance { get; private set; }

    // Variables for StatsManager script (This creates variables and keeps all values always reliable)
    public bool GameReset = false;

    public int PlayerHealth = 300; // WIP
    public int PlayerMaxHealth = 50;
    public int PlayerMana;
    public int maxMana = 50;
    public bool Run = false;


    public bool LvlGet = false; //If player gets level true or false

    public bool GameStart = true;
    public int Lvl, PlayerClass, SkillPoints, Str, Agi, Dex, Int, Con, Luck, Cha, Wis, CritHit;
    public int AllStats; // not in use atm

    public bool StartRandomCrit = true;
    public int Randomizer100 = 100;

    public bool IsCritical = false;

    public bool FightScreen = false;
    public bool FightMusicStart = false; // trigger for music
    public bool EnemyTurn = false;
    public bool PlayerTurn = false;
    public bool EnemyAnimAttack = false;

    public bool PlayerDies = false;


    public bool BasicAttack = false;
    public bool SuperAttack = false;
    public bool UltraAttack = false;
    public bool BasicDefense = false;
    public bool DefenseActiveColor = false;
    public bool BasicAnimAttack = false;
    public bool BasicAnimTackle = false;
    public bool BasicAnimJumphit = false;
    public bool FightTransition = false;
    public bool PlayerCanMove = true;

    public int XPScreen = 0; // 0 = No screen, 1 = Fight screen,
    public int XPpoints;
    public bool XPStart;
    public int XPNextLVL;
    public int EnDies = 0;
    public int EnLvl;

    public bool ParticleActive = false;
    public bool StunActive = false;
    public bool PoisonActive = false;
    public bool ConfusionActive = false;
    public bool WeakenActive = false;
    public bool SlowActive = false;
    public bool BurnActive = false;


    public int EnClass, EnLVL, EnemyHealth = 10, EnemyMaxHealth;
    public int EnStr, EnCon, EnDex, EnAgi, EnInt;
    public bool HealthBarActive = false;


    public int WorldMapPos; // 1 = Home, 2 = Grass, 3 = Oasis, 4 = Tundra, 5 = Volcanic
    public bool MapChange = false;
    
    //overall: 65 booleans and ints

    private void Awake()
    {
        
        if (Instance == null) //if instance contains no data (when game starts) -> dont destroy
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
     
        }
        else
        {
            Destroy(gameObject); //if instance already contains data -> destroy duplicant (dont create again)
        }
        /*
        if (Instance != null && GameReset == true)
        {
            Destroy(gameObject);
            GameReset = false;
        }
        else
        {
            GameReset = false;
        }
        */

    }

    public void Update()
    {
        maxMana = Wis * 10;
        PlayerMaxHealth = Con * 10;

        if (PlayerMaxHealth >= 60)
        if (PlayerHealth+1 > PlayerMaxHealth)
        {
            PlayerHealth = Con * 10;
                

        }


    CritHit = Luck / 4;

        if (StartRandomCrit == true) // If true -> Start randomizing number from 0 - 100
        {
            CriticalHitChance();
            
        }

        if (GameReset == true)
        {
            GameReset = false;
            FightScreen = false;
            FightMusicStart = false;
            PlayerCanMove = true;
            EnDies = 0;
            XPScreen = 0;
            ///*
            Lvl = 1;
            PlayerMana = 100;
            maxMana = 100;
            XPpoints = 0;
            SkillPoints = 0;
            //*/
            GameStart = true;
            EnLVL = 0;
            ParticleActive = false;
            StunActive = false;
            PoisonActive = false;
            ConfusionActive = false;
            WeakenActive = false;
            SlowActive = false;
            BurnActive = false;
            BasicAnimTackle = false;
            BasicAnimJumphit = false;
            BasicAnimAttack = false;
            BasicDefense = false;
            BasicAttack = false;
            SuperAttack = false;
            UltraAttack = false;

        }

    }


    public void CriticalHitChance()
    {
        Randomizer100 = 100; // randomizer variable
        Randomizer100 = Random.Range(0, 100); // Random number from 0 to 100

        if (Randomizer100 <= CritHit)
        {

            IsCritical = true;


        }
        else
        {
            IsCritical = false;

        }

        StartRandomCrit = false;

    }

    public void StatsChecker() // Not in use atm
    {
        AllStats = Lvl + PlayerClass + Str + Agi + Dex + Int + Con + Luck + Cha + Wis + CritHit;

        if (GameReset == true)
        {
            GameReset = false;
           
            PlayerHealth = 100;
        }


    }





}
