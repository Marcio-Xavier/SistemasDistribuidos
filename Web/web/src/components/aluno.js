import React, { Component } from "react";
import Request from "superagent";
import _ from "lodash";

class Aluno extends Component {
  constructor() {
    super();
    this.state = {};
  }

  componentWillMount() {
    var url = "https://localhost:44331/Aluno/Get";
    Request.get(url).then(response => {
      this.setState({
        alunos: response.body
      });
    });
  }

  render() {
    var alunos = _.map(this.state.alunos, aluno => {
      return (
        <tr key={aluno.id}>
          <td>{aluno.id}</td>
          <td>{aluno.nome}</td>
          <td>{aluno.curso}</td>
        </tr>
      );
    });

    return (
      <React.Fragment>
        <div className="row">
          <div className="col-2">
            <button className="btn btn-sm btn-secondary" type="submit">
              Pesquisar todos
            </button>
          </div>
        </div>
        <hr />
        <table className="table table-striped table-dark">
          <thead>
            <tr>
              <th scope="col">ID</th>
              <th scope="col">Nome</th>
              <th scope="col">Curso</th>
            </tr>
          </thead>
          <tbody>{alunos}</tbody>
        </table>
      </React.Fragment>
    );
  }
}

export default Aluno;
