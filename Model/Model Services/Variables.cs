using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
	public class Variables : IVariables
    {
        List<RelationshipUnit> _relations;
        List<string> _genders;
        List<string> _races;
        List<string> _conditions;
        List<string> _specialConditions;

        public Variables()
        {
            _relations = new List<RelationshipUnit>();
            _genders = new List<string>();
            _races = new List<string>();
            _conditions = new List<string>();
            _specialConditions = new List<string>();
            
            LoadVariables();
        }

        public List<RelationshipUnit> Relations { get { return _relations; }	set { _relations = value; }	}
        public List<string> Genders { get { return _genders; }	set { _genders = value; }	}
        public List<string> Races { get { return _races; }	set { _races = value; }	}
        public List<string> Conditions { get { return _conditions; }	set { _conditions = value; }	}
        public List<string> SpecialConditions { get { return _specialConditions; }	set { _specialConditions = value; }	}
        
        public void LoadVariables()
        {
        	JSONSerializer<List<string>> jsonSerializer;
        	
        	string variable = "Genders";        	
        	jsonSerializer = new JSONSerializer<List<string>>(variable); this._genders = jsonSerializer.DeSerialize();
        	
        	variable = "Races";
        	jsonSerializer = new JSONSerializer<List<string>>(variable); this._races = jsonSerializer.DeSerialize();
        	
        	variable = "Conditions";
        	jsonSerializer = new JSONSerializer<List<string>>(variable); this._conditions = jsonSerializer.DeSerialize();
        	
        	variable = "Special_Conditions";
        	jsonSerializer = new JSONSerializer<List<string>>(variable); this._specialConditions = jsonSerializer.DeSerialize();
        	
        	// ---------------------
        	
        	JSONSerializer<List<RelationshipUnit>> anotherJsonSerializer;
        	variable = "Relationships";
        	anotherJsonSerializer = new JSONSerializer<List<RelationshipUnit>>(variable);
        	this._relations = anotherJsonSerializer.DeSerialize();        	
        }
    }
}
