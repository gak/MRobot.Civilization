﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRobot.Civilization.Base;
using System.IO;

namespace MRobot.Civilization.CivBE
{
    public class CivSaveService : ICivSaveService
    {
        public IEnumerable<ICivilization> AllCivilizations
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<PlayerDifficulty> AllDifficulties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Expansion> AllExpansions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Map> AllMaps
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICivilization UknownCiv
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICivilization FindCivById(int id)
        {
            throw new NotImplementedException();
        }

        public GameConfig LoadGameConfig(Stream saveStream)
        {
            throw new NotImplementedException();
        }
    }
}