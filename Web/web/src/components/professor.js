import React, { Component } from "react";
import Request from "superagent";
import _ from "lodash";

class Professor extends Component {
  constructor() {
    super();
    this.state = {};
  }

  componentWillMount() {
    var url = "https://localhost:44357/Professor/Get";
	var urlBackup = "https://localhost:44331/Professor/Get"
    Request.get(url).then(response => {
      this.setState({
        professores: response.body
      })
    });
	
	if (this.state.professores == null || isEmpty(this.state.professores)){
		Request.get(urlBackup).then(response => {
			this.setState({
				professores: response.body
			})
		});	
	}
  }

  render() {
    var professores = _.map(this.state.professores, professor => {
      return (
        <tr key={professor.id}>
          <td>{professor.id}</td>
          <td>{professor.nome}</td>
          <td>{professor.nascimento}</td>
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
              <th scope="col">Nascimento</th>
            </tr>
          </thead>
          <tbody>{professores}</tbody>
        </table>
      </React.Fragment>
    );
  }
}

export default Professor;
