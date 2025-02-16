import React from 'react'

function App() {

  // looping
  const string = 'JSX basics';
  const names = ['Brad', 'Mary', 'Joe', 'Sara'];
  // conditionals
  const loggedIn = true;
  const condition = 'first';
  // style
  const styles = {
    color: 'red'
  }

  return (
    <div>
      <h1>This are { string }</h1>

      <div>
        <h3>looping</h3>
        <ul>
          {names.map((name, index) => (
            <li key={ index }>{ name }</li>
          ))}
        </ul>
      </div>

      <div>
        <h1>conditionals (one line expressions)</h1>
        {/* ternary operator */}
        { loggedIn ? <h3>you are logged in</h3> : <h3>you are not logged in</h3> }
        { loggedIn && <h3>you are logged in</h3> }

        {/* conditional */}
        { condition === 'first' && <h3>first</h3> }
      </div>

      <div>
        <h1 style={ styles }>style</h1>
      </div>

    </div>
  )
}

export default App
