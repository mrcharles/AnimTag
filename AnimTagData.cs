using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AnimTag
{
    class Anim
    {
        public int id;
        public string name;

        public Anim(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
    }

    class Tag
    {
        public int id;
        public string name;
        public Tag(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
    }

    class AnimTagPair : IComparable<AnimTagPair>
    {
        public string anim;
        public string tag;

        public AnimTagPair(Anim _anim, Tag _tag)
        {
            anim = _anim.name;
            tag = _tag.name;
        }

        public int CompareTo(AnimTagPair other)
        {
            if (other.anim == anim && other.tag == tag)
                return 0;

            if (other.anim != anim)
                return 1;
            else
                return -1;
            

        }
    }

    class AnimTagData
    {
        Dictionary<string, Anim> Animations;
        Dictionary<string, Tag> Tags;
        HashSet<AnimTagPair> AnimTagPairs;

        Dictionary<string, Anim> LoadAnims()
        {
            string[] fakeanims = new string[] { "attack_1", "dodgefw", "run", "walk", "climb", "jump" };
            Dictionary<string, Anim> anims = new Dictionary<string, Anim>();

            for (int i = 0; i < fakeanims.Length; i++)
            {
                string name = fakeanims[i];
                anims[name] = new Anim(i, name);
            }

            return anims;
        }

        Dictionary<string, Tag> LoadTags()
        {
            string[] faketags = new string[] { "attack", "dodge", "run", "walk", "climb", "jump", "forward" };
            Dictionary<string, Tag> tags = new Dictionary<string, Tag>();

            for (int i = 0; i < faketags.Length; i++)
            {
                string name = faketags[i];
                tags[name] = new Tag(i, name);
            }

            return tags;
        }

        List<Tag> GetTagsForAnim(Anim anim)
        {
            IEnumerable<AnimTagPair> query = AnimTagPairs.Where(pair => pair.anim == anim.name);
            List<Tag> results = new List<Tag>();
            foreach (AnimTagPair p in query)
            {
                results.Add(Tags[p.tag]);
            }

            return results;
        }

        List<Anim> GetAnimsForTag(Tag tag)
        {
            List<Anim> results = new List<Anim>();

            foreach (AnimTagPair p in AnimTagPairs.Where(pair => pair.tag == tag.name))
            {
                results.Add(Animations[p.anim]);
            }

            return results;
        }

        void AddTag(string animname, string tagname)
        {
            Anim anim = Animations[animname];
            Tag tag = Tags[tagname];

            AnimTagPair pair = new AnimTagPair(anim, tag);
            AnimTagPairs.Add(pair);
        }

        HashSet<AnimTagPair> LoadPairs()
        {
            return new HashSet<AnimTagPair>();
        }

        public void LoadData()
        {
            Animations = LoadAnims();
            Tags = LoadTags();
            AnimTagPairs = LoadPairs();
        }


    }
}
