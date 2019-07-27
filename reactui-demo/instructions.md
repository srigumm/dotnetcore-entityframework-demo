brew install yarn  
yarn create react-app reactui-demo
yarn start
=============================
what is react-scripts eject?
=============================
create-react-app encapsulates all of the npm modules it is using internally, so that your package.json will be very clean and simple without you having to worry about it.

However, if you want to start doing more complex things and installing modules that may interact with modules create-react-app is using under the hood, those new modules need to know what is available and not, meaning you need to have create-react-app un-abstract them.

That, in essence, is what react-scripts eject does. It will stop hiding what it's got installed under the hood and instead eject those things into your project's package.json for everyone to see.

======================
what is service worker?
======================

==============
Add Prettier:
==============
yarn add prettier --dev
yarn add pretty-quick --dev
"scripts":{
"pretty": "pretty-quick"
}

Run => yarn pretty => This should prettify your code.
\*\* you can add --staged and configure only to prettify staged files.

=====
husky
=====
you can use husky hooks and run pretty-quick automatically before commiting your code.

yarn add husky --dev
"husky": {
"hooks": {
"pre-commit": "pretty-quick --staged"
}
}

How to test?
do some dirty formatting in your code like 10 new lines after the function..stage it.. run git commit and see prettier runs before commiting..

======
eslint
======
yarn add eslint-config-prettier --dev
"script":{
"lint":"eslint src/\*\*.js"
}
How to test?
add simple error code like test ="1234" and save your file.

Run => yarn lint
This should show warning like ' 'test' is assigned a value but never used no-unused-vars '

=========
Adding routes in react app
==========

- use "react-router-dom"
  yarn add react-router-dom
- Define routes.js
  import React from "react";
  import { Route, Switch } from 'react-router-dom';
  import Login from "./Components/Login";
  const Routes = ()=> (
  <Switch>
  <Route  path="/" component={Login} />
  </Switch>
  );
  export default Routes;
- Use routes in app.js
  import {BrowserRouter as Router} from 'react-router-dom';
  import Routes from './routes';

     <Router>
         <Routes />
     </Router>
