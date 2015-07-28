using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoComplete
{
    public partial class Form1 : Form
    {
        public string dict_path = Application.StartupPath + @"\wordsEn.txt";
        public Trie local_trie = new Trie();
        public Form1()
        {
            InitializeComponent();
            InitDictionaryFile( dict_path );
        }
        public void InitDictionaryFile( string filepath)
        {
            StreamReader sr = new StreamReader( filepath );
            do
            {
                string str = sr.ReadLine();
                local_trie.insert(str);
            } while (sr.EndOfStream == false );
            sr.Close();
        }

        private void ultraFormattedTextEditor1_TextChanged(object sender, EventArgs e)
        {
            string tmp_str_group  = ultraFormattedTextEditor1.Text;
            char [] delimiter = new[] {' ', ',', '.', ':'};
            string[] group = tmp_str_group.Split(delimiter);
            string tmp_str = group[group.Length - 1];
            if( tmp_str.Length < 3 ) 
                return ;
            local_trie.traversal( tmp_str );
            string tmp = "";
            List<string>.Enumerator enu = local_trie.str_list.GetEnumerator();
            while (enu.MoveNext())
            {
                tmp += enu.Current + "\n";
            }

            foreach (string str in local_trie.str_list )
            {
            }
            ultraFormattedTextEditor2.Value = tmp;
        }
    }

    public class TrieNode
    {
        public Boolean isWord;
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string desc ;
        public TrieNode()
        {
            isWord = false;
            desc = "" ;
        }
    };

    public class Trie 
    {
        private TrieNode root;
        public Trie() 
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void insert(string word) 
        {
            if( word.Length <= 0 ) return ;
            TrieNode node = root ;
            for( int i = 0 ; i < word.Length ; i ++ )
            {
                if (node.children.ContainsKey(word[i]) == false)
                    node.children[word[i]] = new TrieNode();
                node = node.children[word[i] ] ;
            }
            node.isWord = true ;
            node.desc = word ;
        }

        // Returns if the word is in the trie.
        public Boolean search(string word) {
            return retrieve( word , true);
        }

        // Returns if there is any word in the trie
        // that starts with the given prefix.
        public Boolean startsWith(string prefix) {
            return retrieve( prefix, false ) ;
        }
        private Boolean retrieve( string word, Boolean isWord )
        {
            int size = word.Length;
            if( size <= 0 ) return false ;
            TrieNode node = root ;
            for( int i = 0 ; i < size ; i ++ ){
                if( node.children.ContainsKey( word[i] ) == false )
                    return false ;
                node = node.children[ word[i] ] ;
            }
            if (isWord)
                return node.isWord;
            else
                return true;
        }
        public List<string> str_list = new List<string>();
        public int total_string_num = 0 ;
        public void DFS( TrieNode tmpTrieNode, int index, string prefix )
        {
            if( total_string_num > 15 )
                return ;
            if( tmpTrieNode.isWord && index >= prefix.Length)
            {
                Console.WriteLine( tmpTrieNode.desc );
                total_string_num ++ ;
                str_list.Add( tmpTrieNode.desc );
            }
            if ( index < prefix.Length && tmpTrieNode.children.ContainsKey(prefix[index ]) )
            {
                DFS(tmpTrieNode.children[prefix[index]], index + 1 ,prefix );
            } 
            if( index >= prefix.Length ){
                Console.Write( prefix ) ;
                foreach( KeyValuePair< char, TrieNode > pair in tmpTrieNode.children )
                    DFS(  pair.Value, index, prefix ) ;
                return;
            }
        }
        public void traversal( string prefix )
        {
            TrieNode node = root ;
            total_string_num = 0 ;
            str_list.Clear();
            if( prefix == "" ) return ;
            DFS( node , 0 , prefix);

        }

    };
}
