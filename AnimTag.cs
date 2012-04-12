using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimTag
{
    class Anim
    {
        int id;
        string name;
        HashSet<Tag> tags;

        public Anim(int _id, string _name)
        {
            id = _id;
            name = _name;
            tags = new HashSet<Tag>();
        }
    }

    class Tag
    {
        int id;
        string name;
        public Tag(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
    }

    public partial class AnimTagForm : Form
    {
        List<Anim> Animations;
        List<Tag> Tags;

        List<Anim> LoadAnims()
        { 
            string [] fakeanims = new string [] {"attack_1", "dodgefw", "run", "walk", "climb", "jump"};
            List<Anim> anims = new List<Anim>( fakeanims.Length );

            for (int i = 0; i < fakeanims.Length; i++)
            { 
                anims.Add( new Anim( i, fakeanims[i] ));
            }

            return anims;
        }

        List<Tag> LoadTags()
        { 
            string [] faketags = new string [] {"attack", "dodge", "run", "walk", "climb", "jump", "forward"};
            List<Tag> tags = new List<Tag>( faketags.Length );

            for (int i = 0; i < faketags.Length; i++)
            { 
                tags.Add( new Tag( i, faketags[i] ));
            }

            return tags;
        }

        public AnimTagForm()
        {
            InitializeComponent();

            Animations = LoadAnims();
            Tags = LoadTags();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
