using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
      internal class Movie
    {
        string MovieName;
        string MovieProducer;
        string MovieDirector;
        string MaleActor;
        string FemeleActor;

        public void SetMovieName(String nm)
        {
            MovieName = nm;
        }
        public string GetMovieName()
        {

            return MovieName;

        }
        public void SetMovieProducer(string Pro)
        {
            MovieProducer = Pro;
        }
        public string GetMovieProducer()
        {

            return MovieProducer;

        }
        public void SetMovieDirector(String Dir)
        {
            MovieDirector = Dir;
        }
        public string GetMovieDirector()
        {

            return MovieDirector;

        }
        public void SetMaleActor(string act)
        {
            MaleActor = act;
        }
        public string GetMaleActor()
        {

            return MaleActor;

        }
        public void SetFemeleActor(string act)
        {
            FemeleActor = act;
        }
        public string GetFemeleActor()
        {

            return FemeleActor;

        }
        class Movie1
        {
            static void Main(string[] args)
            {
                Movie m1 = new Movie();
                m1.SetMovieName("kgf");
                m1.SetMovieProducer("hh");
                m1.SetMovieDirector("gg");
                m1.SetMaleActor("yash");
                m1.SetFemeleActor("priya");
                Console.WriteLine(m1.GetMovieName());
                Console.WriteLine(m1.GetMovieProducer());
                Console.WriteLine(m1.GetMovieDirector());
                Console.WriteLine(m1.GetMaleActor());
                Console.WriteLine(m1.GetFemeleActor());
            }
            


        }
    }
}