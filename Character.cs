using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2_53__lesson_
{
    class Character
    {
        /* Модификаторы доступа:
            private - всегда по умолчанию. Нет доступа извне.
            public
            protected
            intertal - всегда по умолчанию для класса.
        */

        public int Health = 400;  // поле здоровья.
        
        public void Hit(int damage, int poison )  // метод просто делает что-то. Принимает аргумент - херачит изо всех щелей. 
        {
            Health -= damage; // наносим урон
            Health -= poison; // отравляем
        }

        public void Buff(int recovery, int shield) // метод накладывает бафф
        {
            Health += recovery; // восстанавливаем немного здоровья разово
            Health += shield; // накладывается баф в виде щита регенерации
        }

        public void Normalize(int downHP) // метод ошеломления от излишка здоровья  
        {
            Health -= downHP; // нормализуем состояние здоровья.
        }

        public void Relax(string sleep)
        {
             // ...ZZzz
        }
    }
}
