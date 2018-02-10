using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{

    class Car
    {


        public int MaxSpeed { get; set; }
        //Свойства автомобиля
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        //Проверка вышел ли из строя автомобиль
        private bool carIsDead;

        //Автомобиль имеет радиоприемник
        private Radio theMusicBox = new Radio();


        //Конструкторы
        public Car() { }
        public Car(string name, int speed)
        {
            MaxSpeed = speed;
            PetName = name;
            carIsDead = false;
        }
        public void CrankTunes(bool state)
        {
            //Делегировать запрос внутреннему объекту 
            theMusicBox.TurnOn(state);
        }
        //Проверить, не перегрелся ли автомобиль (должно генерироваться исключение)
        public void Accelerate(int delta)
        {

            if (delta < 0)
                        throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");

            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    Console.WriteLine("{0} has overheated!", PetName);
                    Console.WriteLine(MaxSpeed);

                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    if (carIsDead) throw ex;

                       }
                    else
                    {
                        Console.WriteLine("MaxSpeed = {0}", MaxSpeed);
                    Console.WriteLine("Current Speed = {0}", CurrentSpeed);
                }
                } 
        }
    }
}

