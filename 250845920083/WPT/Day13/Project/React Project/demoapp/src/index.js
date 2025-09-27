import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Function from './Function';

import reportWebVitals from './reportWebVitals';
import Factorial from './Func_factorial';
import Calculator from './Cal';
import UpperCase from './UpperCase';
import RadioUpper from './RadioUpper';
import Dropdown from './Dropdown';

// import Mult_func from './Mult_func';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
   <Function></Function>
   <Calculator></Calculator>
    <Factorial></Factorial>
    <UpperCase></UpperCase>
    <RadioUpper></RadioUpper>
    <Dropdown></Dropdown>
    {/* <Mult_func></Mult_func> */}
  </React.StrictMode>
);

reportWebVitals();
