import React, { Component } from "react";

class Professor extends Component {
  state = {};
  render() {
    return (
      <React.Fragment>
        <div className="row">
          <div className="col-2">
            <input
              type="number"
              min="0"
              className="form-control form-control-sm"
            />
          </div>
          <div className="col-2">
            <button className="btn btn-sm btn-primary" type="submit">
              Pesquisar por ID
            </button>
          </div>
        </div>
        <br />
        <div className="row">
          <div className="col-2">
            <button className="btn btn-sm btn-secondary" type="submit">
              Pesquisar todos
            </button>
          </div>
        </div>
        <hr />
        <table class="table table-striped table-dark">
          <thead>
            <tr>
              <th scope="col">ID</th>
              <th scope="col">Nome</th>
              <th scope="col">Nascimento</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>1</td>
              <td>Teste</td>
              <td>01/01/1990</td>
            </tr>
          </tbody>
        </table>
      </React.Fragment>
    );
  }
}

export default Professor;
