/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 */

import React, { Component } from 'react';
import {
  View,
  Text,
  StyleSheet,
  Image
} from 'react-native';

import { FlatList } from 'react-native-gesture-handler';

export default class Medico extends Component {

  constructor() {
    super();
    this.state = {
      medicos: []
    }
  }

  componentDidMount() {
    this._carregarLista();
  }

  _carregarLista = async () => {
    await fetch('http://192.168.4.224:5000/api/medicos')
      .then(resposta => resposta.json())
      .then(data => this.setState({ medicos: data }))
  }

  render() {
    return (
      <View style={styles.main}>
        <Text style={styles.h1} >Lista de Médicos</Text>
        <FlatList
          data={this.state.medicos}
          keyExtractor={item => item.idMedico}
          renderItem={
            ({ item }) => (
              <View style={styles.lista}>
                <Text style={styles.linha}>{item.idMedico}</Text>
                <Text style={styles.linha}>{item.nome}</Text>
                <Text style={styles.linha}>{item.nascimento}</Text>
                <Text style={styles.linha}>{item.crm}</Text>
                <Text style={styles.linha}>{item.estado}</Text>
              </View>
            )
          }
        />

        <Image
          source={{uri:'https://belojardim.pe.gov.br/beloJardim/wp-content/uploads/2017/04/medical-29_icon-icons.com_73943.png'}}
          style={{ width: 400, height: 400}}
        />
      </View>
    );
  }
}


const styles = StyleSheet.create({
  h1: {
    color: "black",
    textAlign: "center",
    fontSize: 22,
    marginTop: 15,
    marginBottom: 20,
    fontWeight: "bold"
  },
  lista: {
    display: "flex",
    flexDirection: "row",
  },
  main: {
    backgroundColor: "white",
    height: 600
  },
  linha: {
    marginBottom: 5,
    fontWeight: "bold",
    paddingLeft: 15,
    fontSize: 14
  }
})
