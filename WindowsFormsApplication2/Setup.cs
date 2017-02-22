﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2;

namespace Example1
{
    class Setup
    {
        public static List<Commodity> StartingResourcesBasic()
        {
            List<Commodity> startingResources = new List<Commodity>();
            foreach (CommodityType ct in Enum.GetValues(typeof(CommodityType)))
            {
                Commodity c = new Commodity();
                c.DesiredStock = 10;
                c.max = 1;
                c.min = 0.8;
                c.Stock = 10;
                c.Type = ct;
                startingResources.Add(c);
            }
            return startingResources;
        }

        public static void DoJob(Agent agent)
        {
            Random ran = new Random();
            if (agent.Job == Occupation.Farmer)
            {
                foreach(Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Wheat).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Wheat).Stock += 7.767;
            }
            if (agent.Job == Occupation.Fisher)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Fish).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Fish).Stock += 12;
            }
            if (agent.Job == Occupation.Woodworker)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Timber).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Timber).Stock += 2.93;
            }
            if (agent.Job == Occupation.GrapeFarmer)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Grapes).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Grapes).Stock += 2.08155;
            }
            if (agent.Job == Occupation.CattleRancher)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Cattle).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Cattle).Stock += 0.0020548*5;
            }
            if (agent.Job == Occupation.PigRancher)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Pig).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Pig).Stock += .068493*5;
            }
            if (agent.Job == Occupation.FruitVegFarmer)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.FruitVegetables).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.FruitVegetables).Stock += 4.96986;
            }
            if (agent.Job == Occupation.NutFarmer)
            {
                foreach (Commodity c in agent.Commodities)
                {
                    c.DesiredStock = 10;
                }
                agent.Commodities.First(p => p.Type == CommodityType.Nuts).DesiredStock = 0;
                agent.Commodities.First(p => p.Type == CommodityType.Nuts).Stock += 1.15342;
            }
            if(agent.Commodities.First(p=>p.Type ==CommodityType.Fish).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Fish).Stock -= .113424 * 3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Wheat).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Wheat).Stock -= 1.84931*3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Timber).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Timber).Stock -= 1;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Grapes).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Grapes).Stock -= .4 * 3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Cattle).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Cattle).Stock -= .000547945 * 3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Pig).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Pig).Stock -= .00208219 * 3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.FruitVegetables).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.FruitVegetables).Stock -= .747945 * 3;
            }
            if (agent.Commodities.First(p => p.Type == CommodityType.Nuts).Stock > 0)
            {
                agent.Commodities.First(p => p.Type == CommodityType.Nuts).Stock -= .042523 * 3;
            }
        }

    }
    public enum CommodityType
    {
        Fish,
        Wheat,
        Timber,
        Grapes,
        Cattle,
        Pig,
        FruitVegetables,
        Nuts
    }
    public enum Occupation
    {
        Fisher,
        Farmer,
        Woodworker,
        GrapeFarmer,
        CattleRancher,
        PigRancher,
        FruitVegFarmer,
        NutFarmer
    }
}
