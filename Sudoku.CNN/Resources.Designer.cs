﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.CNN {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sudoku.CNN.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import numpy as np
        ///import pandas as pd
        ///from sklearn.model_selection import train_test_split
        ///
        ///def get_data(file):
        ///
        ///    data = pd.read_csv(file)
        ///
        ///    feat_raw = data[&apos;quizzes&apos;]
        ///    label_raw = data[&apos;solutions&apos;]
        ///
        ///    feat = []
        ///    label = []
        ///
        ///    for i in feat_raw:
        ///
        ///        x = np.array([int(j) for j in i]).reshape((9,9,1))
        ///        feat.append(x)
        ///
        ///    feat = np.array(feat)
        ///    feat = feat/9
        ///    feat -= .5
        ///
        ///    for i in label_raw:
        ///
        ///        x = np.array([int(j) for j in i]).reshape((81,1 [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string data_processes {
            get {
                return ResourceManager.GetString("data_processes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import keras
        ///from keras.layers import Activation
        ///from keras.layers import Conv2D, BatchNormalization, Dense, Flatten, Reshape
        ///
        ///def get_model():
        ///
        ///    model = keras.models.Sequential()
        ///
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;, input_shape=(9,9,1)))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(128, kernel_size=(1,1), activation=&apos;relu&apos;, [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string model {
            get {
                return ResourceManager.GetString("model", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import copy
        ///import keras
        ///import numpy as np
        ///# from model import get_model
        ///# from scripts.data_processes import get_data
        ///
        ///
        ///
        ///x_train, x_test, y_train, y_test = get_data(&apos;data/sudoku.csv&apos;)
        ///
        ///print(x_train)
        ///
        ///
        ///model = get_model()
        ///
        ///adam = keras.optimizers.Adam(lr=.001)
        ///model.compile(loss=&apos;sparse_categorical_crossentropy&apos;, optimizer=adam)
        ///
        ///model.fit(x_train, y_train, batch_size=32, epochs=2)
        ///
        ///model = keras.models.load_model(&apos;model/sudoku.model&apos;)
        ///
        ///
        ///def norm(a):
        ///    return (a/9)-.5
        ///
        ///
        ///
        ///def  [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Sudoku_py {
            get {
                return ResourceManager.GetString("Sudoku.py", resourceCulture);
            }
        }
    }
}
