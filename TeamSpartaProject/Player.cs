﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpartanTeamProject
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Job {  get; set; }
        public double Attack { get; set; }
        public double Deffense { get; set; }
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public int Exp { get; set; } // 경험치
        public int ExpNextLevel { get; set; } // 추가 경험치
        public double Gold { get; set; }

        public Player(string name, int level, string job, float attack, float deffense, float health, float maxHealth, int exp, int expNextLevel, float gold)
        {
            Name = name;
            Level = level;
            Job = job; 
            Attack = attack;
            Deffense = deffense;
            Health = health; //현재 체력
            MaxHealth = maxHealth;//최대 체력
            Exp = exp; // 경험치
            ExpNextLevel = expNextLevel; // 추가 경험치
            Gold = gold;
        }

        public void Info()
        {
            Console.WriteLine($"Lv. {Level}");
            Console.WriteLine($"{Name} ( {Job} )");
            Console.WriteLine($"공격력 : {Attack}");
            Console.WriteLine($"방어력 : {Deffense}");
            Console.WriteLine($"현재 체력 : {Health}");
            Console.WriteLine($"최대 체력 : {MaxHealth}");
            Console.WriteLine($"Gold : {Gold} G");
        }

        public int PlayerAttack()
        {
            Random rand = new Random();

            int damage = 0;
            double difference = 0;
            difference = Math.Ceiling(Attack * 0.1);
            damage = rand.Next((int)Attack - (int)difference, (int)Attack + (int)difference + 1);

            return damage;
        }

        //// 레벨업 확인
        //public void CheckLevelUp()
        //{
        //    if (Exp >= ExpNextLevel)
        //    {
        //        LevelUp();  // 경험치가 목표에 도달하면 레벨업
        //    }
        //}
        //// 레벨업 메서드
        //private void LevelUp()
        //{
        //    Level++;
        //    Attack += 0.5;  // 레벨업 시 공격력 증가
        //    Deffense += 1;   // 레벨업 시 방어력 증가
        //    Exp -= ExpNextLevel;  // 레벨업 후 경험치 초기화
        //    ExpNextLevel = (int)(ExpNextLevel * 3.5);  // 다음 레벨업까지 필요한 경험치 증가
        //    Console.WriteLine($"{Name}이(가) 레벨 {Level}로 상승했습니다!");
        //}
        //// 몬스터 처치 후 경험치 추가
        //public void GainExp(Monster monster)
        //{
        //    Exp += monster.GetExp();  // 몬스터의 경험치만큼 추가
        //    Console.WriteLine($"{monster.Name} 처치! 경험치 {monster.GetExp()} 획득!");

        //    CheckLevelUp();  // 레벨업 체크
        //}
        //// 골드 획득
        //public void GainGold(Monster monster)
        //{
        //    int gold = monster.GetGold();
        //    Gold += gold;
        //    Console.WriteLine($"{monster.Name} 처치! 골드 {gold} 획득! 현재 골드: {Gold}");
        //}
        //// 배틀 승리 보상
        //public void BattleWin(Monster monster)
        //{
        //    GainExp(monster);
        //    GainGold(monster);
        //}

        // 경험치로 레벨업을 처리
        public void LevelUp()
        {
            while (Exp >= Level * 10)  // 레벨 10당 경험치 필요
            {
                Level++;
                Attack += 0.5;
                Deffense += 1;
                Exp -= Level * 10;
                Console.WriteLine($"레벨업! 새로운 레벨: {Level}, 공격력: {Attack}, 방어력: {Deffense}");
            }
        }
        



    }
}
