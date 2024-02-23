/*! For license information please see background.js.LICENSE.txt */
!function(t){var e={};function r(n){if(e[n])return e[n].exports;var o=e[n]={i:n,l:!1,exports:{}};return t[n].call(o.exports,o,o.exports,r),o.l=!0,o.exports}r.m=t,r.c=e,r.d=function(t,e,n){r.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:n})},r.r=function(t){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},r.t=function(t,e){if(1&e&&(t=r(t)),8&e)return t;if(4&e&&"object"==typeof t&&t&&t.__esModule)return t;var n=Object.create(null);if(r.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var o in t)r.d(n,o,function(e){return t[e]}.bind(null,o));return n},r.n=function(t){var e=t&&t.__esModule?function(){return t.default}:function(){return t};return r.d(e,"a",e),e},r.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},r.p="",r(r.s=365)}({365:function(t,e,r){"use strict";function n(t){return n="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},n(t)}function o(t){return function(t){if(Array.isArray(t))return a(t)}(t)||function(t){if("undefined"!=typeof Symbol&&null!=t[Symbol.iterator]||null!=t["@@iterator"])return Array.from(t)}(t)||function(t,e){if(!t)return;if("string"==typeof t)return a(t,e);var r=Object.prototype.toString.call(t).slice(8,-1);"Object"===r&&t.constructor&&(r=t.constructor.name);if("Map"===r||"Set"===r)return Array.from(t);if("Arguments"===r||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r))return a(t,e)}(t)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function a(t,e){(null==e||e>t.length)&&(e=t.length);for(var r=0,n=new Array(e);r<e;r++)n[r]=t[r];return n}function i(){i=function(){return e};var t,e={},r=Object.prototype,o=r.hasOwnProperty,a=Object.defineProperty||function(t,e,r){t[e]=r.value},u="function"==typeof Symbol?Symbol:{},c=u.iterator||"@@iterator",s=u.asyncIterator||"@@asyncIterator",l=u.toStringTag||"@@toStringTag";function f(t,e,r){return Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}),t[e]}try{f({},"")}catch(t){f=function(t,e,r){return t[e]=r}}function h(t,e,r,n){var o=e&&e.prototype instanceof g?e:g,i=Object.create(o.prototype),u=new N(n||[]);return a(i,"_invoke",{value:_(t,r,u)}),i}function p(t,e,r){try{return{type:"normal",arg:t.call(e,r)}}catch(t){return{type:"throw",arg:t}}}e.wrap=h;var d="suspendedStart",v="suspendedYield",y="executing",m="completed",b={};function g(){}function w(){}function x(){}var k={};f(k,c,(function(){return this}));var L=Object.getPrototypeOf,j=L&&L(L(D([])));j&&j!==r&&o.call(j,c)&&(k=j);var E=x.prototype=g.prototype=Object.create(k);function O(t){["next","throw","return"].forEach((function(e){f(t,e,(function(t){return this._invoke(e,t)}))}))}function I(t,e){function r(a,i,u,c){var s=p(t[a],t,i);if("throw"!==s.type){var l=s.arg,f=l.value;return f&&"object"==n(f)&&o.call(f,"__await")?e.resolve(f.__await).then((function(t){r("next",t,u,c)}),(function(t){r("throw",t,u,c)})):e.resolve(f).then((function(t){l.value=t,u(l)}),(function(t){return r("throw",t,u,c)}))}c(s.arg)}var i;a(this,"_invoke",{value:function(t,n){function o(){return new e((function(e,o){r(t,n,e,o)}))}return i=i?i.then(o,o):o()}})}function _(e,r,n){var o=d;return function(a,i){if(o===y)throw new Error("Generator is already running");if(o===m){if("throw"===a)throw i;return{value:t,done:!0}}for(n.method=a,n.arg=i;;){var u=n.delegate;if(u){var c=S(u,n);if(c){if(c===b)continue;return c}}if("next"===n.method)n.sent=n._sent=n.arg;else if("throw"===n.method){if(o===d)throw o=m,n.arg;n.dispatchException(n.arg)}else"return"===n.method&&n.abrupt("return",n.arg);o=y;var s=p(e,r,n);if("normal"===s.type){if(o=n.done?m:v,s.arg===b)continue;return{value:s.arg,done:n.done}}"throw"===s.type&&(o=m,n.method="throw",n.arg=s.arg)}}}function S(e,r){var n=r.method,o=e.iterator[n];if(o===t)return r.delegate=null,"throw"===n&&e.iterator.return&&(r.method="return",r.arg=t,S(e,r),"throw"===r.method)||"return"!==n&&(r.method="throw",r.arg=new TypeError("The iterator does not provide a '"+n+"' method")),b;var a=p(o,e.iterator,r.arg);if("throw"===a.type)return r.method="throw",r.arg=a.arg,r.delegate=null,b;var i=a.arg;return i?i.done?(r[e.resultName]=i.value,r.next=e.nextLoc,"return"!==r.method&&(r.method="next",r.arg=t),r.delegate=null,b):i:(r.method="throw",r.arg=new TypeError("iterator result is not an object"),r.delegate=null,b)}function P(t){var e={tryLoc:t[0]};1 in t&&(e.catchLoc=t[1]),2 in t&&(e.finallyLoc=t[2],e.afterLoc=t[3]),this.tryEntries.push(e)}function T(t){var e=t.completion||{};e.type="normal",delete e.arg,t.completion=e}function N(t){this.tryEntries=[{tryLoc:"root"}],t.forEach(P,this),this.reset(!0)}function D(e){if(e||""===e){var r=e[c];if(r)return r.call(e);if("function"==typeof e.next)return e;if(!isNaN(e.length)){var a=-1,i=function r(){for(;++a<e.length;)if(o.call(e,a))return r.value=e[a],r.done=!1,r;return r.value=t,r.done=!0,r};return i.next=i}}throw new TypeError(n(e)+" is not iterable")}return w.prototype=x,a(E,"constructor",{value:x,configurable:!0}),a(x,"constructor",{value:w,configurable:!0}),w.displayName=f(x,l,"GeneratorFunction"),e.isGeneratorFunction=function(t){var e="function"==typeof t&&t.constructor;return!!e&&(e===w||"GeneratorFunction"===(e.displayName||e.name))},e.mark=function(t){return Object.setPrototypeOf?Object.setPrototypeOf(t,x):(t.__proto__=x,f(t,l,"GeneratorFunction")),t.prototype=Object.create(E),t},e.awrap=function(t){return{__await:t}},O(I.prototype),f(I.prototype,s,(function(){return this})),e.AsyncIterator=I,e.async=function(t,r,n,o,a){void 0===a&&(a=Promise);var i=new I(h(t,r,n,o),a);return e.isGeneratorFunction(r)?i:i.next().then((function(t){return t.done?t.value:i.next()}))},O(E),f(E,l,"Generator"),f(E,c,(function(){return this})),f(E,"toString",(function(){return"[object Generator]"})),e.keys=function(t){var e=Object(t),r=[];for(var n in e)r.push(n);return r.reverse(),function t(){for(;r.length;){var n=r.pop();if(n in e)return t.value=n,t.done=!1,t}return t.done=!0,t}},e.values=D,N.prototype={constructor:N,reset:function(e){if(this.prev=0,this.next=0,this.sent=this._sent=t,this.done=!1,this.delegate=null,this.method="next",this.arg=t,this.tryEntries.forEach(T),!e)for(var r in this)"t"===r.charAt(0)&&o.call(this,r)&&!isNaN(+r.slice(1))&&(this[r]=t)},stop:function(){this.done=!0;var t=this.tryEntries[0].completion;if("throw"===t.type)throw t.arg;return this.rval},dispatchException:function(e){if(this.done)throw e;var r=this;function n(n,o){return u.type="throw",u.arg=e,r.next=n,o&&(r.method="next",r.arg=t),!!o}for(var a=this.tryEntries.length-1;a>=0;--a){var i=this.tryEntries[a],u=i.completion;if("root"===i.tryLoc)return n("end");if(i.tryLoc<=this.prev){var c=o.call(i,"catchLoc"),s=o.call(i,"finallyLoc");if(c&&s){if(this.prev<i.catchLoc)return n(i.catchLoc,!0);if(this.prev<i.finallyLoc)return n(i.finallyLoc)}else if(c){if(this.prev<i.catchLoc)return n(i.catchLoc,!0)}else{if(!s)throw new Error("try statement without catch or finally");if(this.prev<i.finallyLoc)return n(i.finallyLoc)}}}},abrupt:function(t,e){for(var r=this.tryEntries.length-1;r>=0;--r){var n=this.tryEntries[r];if(n.tryLoc<=this.prev&&o.call(n,"finallyLoc")&&this.prev<n.finallyLoc){var a=n;break}}a&&("break"===t||"continue"===t)&&a.tryLoc<=e&&e<=a.finallyLoc&&(a=null);var i=a?a.completion:{};return i.type=t,i.arg=e,a?(this.method="next",this.next=a.finallyLoc,b):this.complete(i)},complete:function(t,e){if("throw"===t.type)throw t.arg;return"break"===t.type||"continue"===t.type?this.next=t.arg:"return"===t.type?(this.rval=this.arg=t.arg,this.method="return",this.next="end"):"normal"===t.type&&e&&(this.next=e),b},finish:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var r=this.tryEntries[e];if(r.finallyLoc===t)return this.complete(r.completion,r.afterLoc),T(r),b}},catch:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var r=this.tryEntries[e];if(r.tryLoc===t){var n=r.completion;if("throw"===n.type){var o=n.arg;T(r)}return o}}throw new Error("illegal catch attempt")},delegateYield:function(e,r,n){return this.delegate={iterator:D(e),resultName:r,nextLoc:n},"next"===this.method&&(this.arg=t),b}},e}function u(t,e,r,n,o,a,i){try{var u=t[a](i),c=u.value}catch(t){return void r(t)}u.done?e(c):Promise.resolve(c).then(n,o)}function c(t){return function(){var e=this,r=arguments;return new Promise((function(n,o){var a=t.apply(e,r);function i(t){u(a,n,o,i,c,"next",t)}function c(t){u(a,n,o,i,c,"throw",t)}i(void 0)}))}}function s(t,e){for(var r=0;r<e.length;r++){var o=e[r];o.enumerable=o.enumerable||!1,o.configurable=!0,"value"in o&&(o.writable=!0),Object.defineProperty(t,(a=o.key,i=void 0,i=function(t,e){if("object"!==n(t)||null===t)return t;var r=t[Symbol.toPrimitive];if(void 0!==r){var o=r.call(t,e||"default");if("object"!==n(o))return o;throw new TypeError("@@toPrimitive must return a primitive value.")}return("string"===e?String:Number)(t)}(a,"string"),"symbol"===n(i)?i:String(i)),o)}var a,i}r.r(e);var l=function(){function t(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:1e4;!function(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}(this,t),this.Y6i0=e,this.H6j2H=new Map,this.z6laB=new Map,this.u6p1=!1}var e,r,n,a,u,l,f,h,p;return e=t,r=[{key:"D5m8D",value:(p=c(i().mark((function t(){var e;return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:e=1;case 1:if(!(e<100)){t.next=10;break}if(this.u6p1){t.next=5;break}return this.u6p1=!0,t.abrupt("return",!0);case 5:return t.next=7,new Promise((function(t){setTimeout(t,50)}));case 7:e++,t.next=1;break;case 10:return this.u6p1=!0,t.abrupt("return",!0);case 12:case"end":return t.stop()}}),t,this)}))),function(){return p.apply(this,arguments)})},{key:"O5nh",value:(h=c(i().mark((function t(){return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return this.u6p1=!1,t.abrupt("return",!0);case 2:case"end":return t.stop()}}),t,this)}))),function(){return h.apply(this,arguments)})},{key:"v5o7v",value:(f=c(i().mark((function t(e,r){return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.D5m8D();case 2:return this.H6j2H.set(e,r),t.next=5,this.O5nh();case 5:case"end":return t.stop()}}),t,this)}))),function(t,e){return f.apply(this,arguments)})},{key:"U61a",value:(l=c(i().mark((function t(e,r){var n,a,u;return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.D5m8D();case 2:if(this.H6j2H.size>=this.Y6i0)for(n=o(this.z6laB).sort((function(t,e){return t[1]-e[1]})),a=Math.min(n.length,this.Y6i0/5),u=a;u>=0;u--)this.T699V(n[u][0]);return this.H6j2H.set(e,r),this.z6laB.set(e,Date.now()),t.next=7,this.O5nh();case 7:case"end":return t.stop()}}),t,this)}))),function(t,e){return l.apply(this,arguments)})},{key:"I62d",value:function(t){if(this.H6j2H.has(t))return this.z6laB.has(t)&&this.z6laB.set(t,Date.now()),this.H6j2H.get(t)}},{key:"D64pF",value:function(t){return this.z6laB.get(t)}},{key:"N667N",value:function(t){return this.H6j2H.has(t)}},{key:"T699V",value:(u=c(i().mark((function t(e){return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.D5m8D();case 2:return this.H6j2H.delete(e),this.z6laB.delete(e),t.next=6,this.O5nh();case 6:case"end":return t.stop()}}),t,this)}))),function(t){return u.apply(this,arguments)})},{key:"J6dfN",value:(a=c(i().mark((function t(){return i().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.D5m8D();case 2:return this.H6j2H.clear(),this.z6laB.clear(),t.next=6,this.O5nh();case 6:case"end":return t.stop()}}),t,this)}))),function(){return a.apply(this,arguments)})},{key:"J6g7L",value:function(){return Array.from(this.H6j2H.keys())}}],r&&s(e.prototype,r),n&&s(e,n),Object.defineProperty(e,"prototype",{writable:!1}),t}();function f(t){return f="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},f(t)}function h(t,e){for(var r=0;r<e.length;r++){var n=e[r];n.enumerable=n.enumerable||!1,n.configurable=!0,"value"in n&&(n.writable=!0),Object.defineProperty(t,(o=n.key,a=void 0,a=function(t,e){if("object"!==f(t)||null===t)return t;var r=t[Symbol.toPrimitive];if(void 0!==r){var n=r.call(t,e||"default");if("object"!==f(n))return n;throw new TypeError("@@toPrimitive must return a primitive value.")}return("string"===e?String:Number)(t)}(o,"string"),"symbol"===f(a)?a:String(a)),n)}var o,a}var p=function(){function t(e){!function(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}(this,t),this.limit=e,this.items=[]}var e,r,n;return e=t,r=[{key:"enqueue",value:function(t){if(this.isFull()){var e=Math.floor(this.limit/10);this.dequeues(e)}this.items.push(t)}},{key:"dequeue",value:function(){return this.isEmpty()?null:this.items.shift()}},{key:"dequeues",value:function(){var t=arguments.length>0&&void 0!==arguments[0]?arguments[0]:1;if(this.isEmpty())return null;for(var e=[];t-- >0&&!this.isEmpty();)e.push(this.items.shift());return e}},{key:"isEmpty",value:function(){return 0===this.items.length}},{key:"isFull",value:function(){return this.items.length===this.limit}},{key:"peek",value:function(){return this.isEmpty()?null:this.items[0]}},{key:"size",value:function(){return this.items.length}},{key:"has",value:function(t){this.items.includes(t)}}],r&&h(e.prototype,r),n&&h(e,n),Object.defineProperty(e,"prototype",{writable:!1}),t}();function d(t){return d="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},d(t)}function v(){v=function(){return e};var t,e={},r=Object.prototype,n=r.hasOwnProperty,o=Object.defineProperty||function(t,e,r){t[e]=r.value},a="function"==typeof Symbol?Symbol:{},i=a.iterator||"@@iterator",u=a.asyncIterator||"@@asyncIterator",c=a.toStringTag||"@@toStringTag";function s(t,e,r){return Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}),t[e]}try{s({},"")}catch(t){s=function(t,e,r){return t[e]=r}}function l(t,e,r,n){var a=e&&e.prototype instanceof g?e:g,i=Object.create(a.prototype),u=new N(n||[]);return o(i,"_invoke",{value:_(t,r,u)}),i}function f(t,e,r){try{return{type:"normal",arg:t.call(e,r)}}catch(t){return{type:"throw",arg:t}}}e.wrap=l;var h="suspendedStart",p="suspendedYield",y="executing",m="completed",b={};function g(){}function w(){}function x(){}var k={};s(k,i,(function(){return this}));var L=Object.getPrototypeOf,j=L&&L(L(D([])));j&&j!==r&&n.call(j,i)&&(k=j);var E=x.prototype=g.prototype=Object.create(k);function O(t){["next","throw","return"].forEach((function(e){s(t,e,(function(t){return this._invoke(e,t)}))}))}function I(t,e){function r(o,a,i,u){var c=f(t[o],t,a);if("throw"!==c.type){var s=c.arg,l=s.value;return l&&"object"==d(l)&&n.call(l,"__await")?e.resolve(l.__await).then((function(t){r("next",t,i,u)}),(function(t){r("throw",t,i,u)})):e.resolve(l).then((function(t){s.value=t,i(s)}),(function(t){return r("throw",t,i,u)}))}u(c.arg)}var a;o(this,"_invoke",{value:function(t,n){function o(){return new e((function(e,o){r(t,n,e,o)}))}return a=a?a.then(o,o):o()}})}function _(e,r,n){var o=h;return function(a,i){if(o===y)throw new Error("Generator is already running");if(o===m){if("throw"===a)throw i;return{value:t,done:!0}}for(n.method=a,n.arg=i;;){var u=n.delegate;if(u){var c=S(u,n);if(c){if(c===b)continue;return c}}if("next"===n.method)n.sent=n._sent=n.arg;else if("throw"===n.method){if(o===h)throw o=m,n.arg;n.dispatchException(n.arg)}else"return"===n.method&&n.abrupt("return",n.arg);o=y;var s=f(e,r,n);if("normal"===s.type){if(o=n.done?m:p,s.arg===b)continue;return{value:s.arg,done:n.done}}"throw"===s.type&&(o=m,n.method="throw",n.arg=s.arg)}}}function S(e,r){var n=r.method,o=e.iterator[n];if(o===t)return r.delegate=null,"throw"===n&&e.iterator.return&&(r.method="return",r.arg=t,S(e,r),"throw"===r.method)||"return"!==n&&(r.method="throw",r.arg=new TypeError("The iterator does not provide a '"+n+"' method")),b;var a=f(o,e.iterator,r.arg);if("throw"===a.type)return r.method="throw",r.arg=a.arg,r.delegate=null,b;var i=a.arg;return i?i.done?(r[e.resultName]=i.value,r.next=e.nextLoc,"return"!==r.method&&(r.method="next",r.arg=t),r.delegate=null,b):i:(r.method="throw",r.arg=new TypeError("iterator result is not an object"),r.delegate=null,b)}function P(t){var e={tryLoc:t[0]};1 in t&&(e.catchLoc=t[1]),2 in t&&(e.finallyLoc=t[2],e.afterLoc=t[3]),this.tryEntries.push(e)}function T(t){var e=t.completion||{};e.type="normal",delete e.arg,t.completion=e}function N(t){this.tryEntries=[{tryLoc:"root"}],t.forEach(P,this),this.reset(!0)}function D(e){if(e||""===e){var r=e[i];if(r)return r.call(e);if("function"==typeof e.next)return e;if(!isNaN(e.length)){var o=-1,a=function r(){for(;++o<e.length;)if(n.call(e,o))return r.value=e[o],r.done=!1,r;return r.value=t,r.done=!0,r};return a.next=a}}throw new TypeError(d(e)+" is not iterable")}return w.prototype=x,o(E,"constructor",{value:x,configurable:!0}),o(x,"constructor",{value:w,configurable:!0}),w.displayName=s(x,c,"GeneratorFunction"),e.isGeneratorFunction=function(t){var e="function"==typeof t&&t.constructor;return!!e&&(e===w||"GeneratorFunction"===(e.displayName||e.name))},e.mark=function(t){return Object.setPrototypeOf?Object.setPrototypeOf(t,x):(t.__proto__=x,s(t,c,"GeneratorFunction")),t.prototype=Object.create(E),t},e.awrap=function(t){return{__await:t}},O(I.prototype),s(I.prototype,u,(function(){return this})),e.AsyncIterator=I,e.async=function(t,r,n,o,a){void 0===a&&(a=Promise);var i=new I(l(t,r,n,o),a);return e.isGeneratorFunction(r)?i:i.next().then((function(t){return t.done?t.value:i.next()}))},O(E),s(E,c,"Generator"),s(E,i,(function(){return this})),s(E,"toString",(function(){return"[object Generator]"})),e.keys=function(t){var e=Object(t),r=[];for(var n in e)r.push(n);return r.reverse(),function t(){for(;r.length;){var n=r.pop();if(n in e)return t.value=n,t.done=!1,t}return t.done=!0,t}},e.values=D,N.prototype={constructor:N,reset:function(e){if(this.prev=0,this.next=0,this.sent=this._sent=t,this.done=!1,this.delegate=null,this.method="next",this.arg=t,this.tryEntries.forEach(T),!e)for(var r in this)"t"===r.charAt(0)&&n.call(this,r)&&!isNaN(+r.slice(1))&&(this[r]=t)},stop:function(){this.done=!0;var t=this.tryEntries[0].completion;if("throw"===t.type)throw t.arg;return this.rval},dispatchException:function(e){if(this.done)throw e;var r=this;function o(n,o){return u.type="throw",u.arg=e,r.next=n,o&&(r.method="next",r.arg=t),!!o}for(var a=this.tryEntries.length-1;a>=0;--a){var i=this.tryEntries[a],u=i.completion;if("root"===i.tryLoc)return o("end");if(i.tryLoc<=this.prev){var c=n.call(i,"catchLoc"),s=n.call(i,"finallyLoc");if(c&&s){if(this.prev<i.catchLoc)return o(i.catchLoc,!0);if(this.prev<i.finallyLoc)return o(i.finallyLoc)}else if(c){if(this.prev<i.catchLoc)return o(i.catchLoc,!0)}else{if(!s)throw new Error("try statement without catch or finally");if(this.prev<i.finallyLoc)return o(i.finallyLoc)}}}},abrupt:function(t,e){for(var r=this.tryEntries.length-1;r>=0;--r){var o=this.tryEntries[r];if(o.tryLoc<=this.prev&&n.call(o,"finallyLoc")&&this.prev<o.finallyLoc){var a=o;break}}a&&("break"===t||"continue"===t)&&a.tryLoc<=e&&e<=a.finallyLoc&&(a=null);var i=a?a.completion:{};return i.type=t,i.arg=e,a?(this.method="next",this.next=a.finallyLoc,b):this.complete(i)},complete:function(t,e){if("throw"===t.type)throw t.arg;return"break"===t.type||"continue"===t.type?this.next=t.arg:"return"===t.type?(this.rval=this.arg=t.arg,this.method="return",this.next="end"):"normal"===t.type&&e&&(this.next=e),b},finish:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var r=this.tryEntries[e];if(r.finallyLoc===t)return this.complete(r.completion,r.afterLoc),T(r),b}},catch:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var r=this.tryEntries[e];if(r.tryLoc===t){var n=r.completion;if("throw"===n.type){var o=n.arg;T(r)}return o}}throw new Error("illegal catch attempt")},delegateYield:function(e,r,n){return this.delegate={iterator:D(e),resultName:r,nextLoc:n},"next"===this.method&&(this.arg=t),b}},e}function y(t,e,r){return(e=function(t){var e=function(t,e){if("object"!==d(t)||null===t)return t;var r=t[Symbol.toPrimitive];if(void 0!==r){var n=r.call(t,e||"default");if("object"!==d(n))return n;throw new TypeError("@@toPrimitive must return a primitive value.")}return("string"===e?String:Number)(t)}(t,"string");return"symbol"===d(e)?e:String(e)}(e))in t?Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[e]=r,t}function m(t,e,r,n,o,a,i){try{var u=t[a](i),c=u.value}catch(t){return void r(t)}u.done?e(c):Promise.resolve(c).then(n,o)}function b(t){return function(){var e=this,r=arguments;return new Promise((function(n,o){var a=t.apply(e,r);function i(t){m(a,n,o,i,u,"next",t)}function u(t){m(a,n,o,i,u,"throw",t)}i(void 0)}))}}b(v().mark((function t(){var e,r,n,o,a,i,u,c,s,f,h,d,m,g,w,x,k,L,j,E;return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:E=function(){return(E=b(v().mark((function t(e,r,n){return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,chrome.tabs.sendMessage(r.tab.id,{type:"T149T",label:{hkId:n}},{documentId:r.documentId,frameId:r.frameId});case 3:t.next=9;break;case 5:t.prev=5,t.t0=t.catch(0),"Kho0"===e&&clearInterval(a[n]),delete a[n];case 9:case"end":return t.stop()}}),t,null,[[0,5]])})))).apply(this,arguments)},j=function(t,e,r){return E.apply(this,arguments)},L=function(){return L=b(v().mark((function t(){var e,r,o,a,i,u;return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:e=n.I62d("__scope"),r=!1,"00"===e&&(r=!0),o=!1,a=n.I62d("J7ifL"),i=Object.values(a||{}),u=0;case 7:if(!(u<i.length)){t.next=14;break}if(!i[u].connected){t.next=11;break}return o=!0,t.abrupt("break",14);case 11:u++,t.next=7;break;case 14:if(!r){t.next=19;break}return t.next=17,chrome.action.setIcon({path:{128:"static/icons/cs_logo-128_stopped.png"}});case 17:t.next=26;break;case 19:if(!o){t.next=24;break}return t.next=22,chrome.action.setIcon({path:{128:"static/icons/cs_logo-128_linked.png"}});case 22:t.next=26;break;case 24:return t.next=26,chrome.action.setIcon({path:{128:"static/icons/cs_logo-128.png"}});case 26:case"end":return t.stop()}}),t)}))),L.apply(this,arguments)},k=function(){return L.apply(this,arguments)},x=function(){return(x=b(v().mark((function t(){var e,o,a,i,u;return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:e=Object.keys(r),o=h(),a=n.I62d("J7ifL"),i=0;case 4:if(!(i<e.length)){t.next=24;break}return t.prev=5,t.next=9,chrome.runtime.sendMessage(e[i],{action:"CSL15il",data:{id:chrome.runtime.id,ver:chrome.runtime.getManifest().version,reqV:r[e[i]].minVer,token:o,ts:Date.now()}});case 9:"success"===(null==(u=t.sent)?void 0:u.status)&&(null==u?void 0:u.token)===o?(a[e[i]].connected=!0,a[e[i]].ts=Date.now(),a[e[i]].message=null==u?void 0:u.message):(a[e[i]].connected=!1,a[e[i]].ts=Date.now(),(null==u?void 0:u.token)!==o?a[e[i]].message="invalid connection":a[e[i]].message=(null==u?void 0:u.message)||"n/a"),t.next=21;break;case 14:t.prev=14,t.t0=t.catch(5),a[e[i]].connected=!1,a[e[i]].ts=Date.now(),a[e[i]].message="not reachable";case 21:i++,t.next=4;break;case 24:return t.next=26,n.U61a("J7ifL",a);case 26:return t.next=28,k();case 28:case"end":return t.stop()}}),t,null,[[5,14]])})))).apply(this,arguments)},w=function(){return x.apply(this,arguments)},g=function(){return g=b(v().mark((function t(e){var r,o,a=arguments;return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(a.length>1&&void 0!==a[1]?a[1]:void 0,r="Agkm",!e){t.next=9;break}if(!(o=n.I62d(e))){t.next=9;break}if(r=o.uggp,!o.Rgd8R||!["Qhb8","xhjgB","Whl7"].indexOf(r)){t.next=9;break}return t.next=9,n.T699V(e);case 9:return t.abrupt("return",r);case 10:case"end":return t.stop()}}),t)}))),g.apply(this,arguments)},m=function(t){return g.apply(this,arguments)},d=function(){return{Rgd8R:arguments.length>0&&void 0!==arguments[0]&&arguments[0],uggp:arguments.length>1&&void 0!==arguments[1]?arguments[1]:"Ngm4N",updatedAt:Date.now()}},h=function(){return Date.now()+Math.random()},e={__scope:"02"},(r={}).ojaffphbffmdaicdkahnmihipclmepok={name:chrome.i18n.getMessage("partner_nds"),curVer:"",minVer:"3.0.45",url:"https://chromewebstore.google.com/detail/nocoding-data-scraper-eas/ojaffphbffmdaicdkahnmihipclmepok",connected:!1,message:"",ts:void 0},n=new l(3e3),o=new p(1e3),a={},i=Object.keys(e),u=0;case 20:if(!(u<i.length)){t.next=26;break}return t.next=23,n.v5o7v(i[u],e[i[u]]);case 23:u++,t.next=20;break;case 26:return t.next=28,n.v5o7v("J7ifL",r);case 28:return t.next=30,chrome.storage.local.get(null);case 30:if(!(c=t.sent)){t.next=40;break}s=Object.keys(c),f=0;case 34:if(!(f<s.length)){t.next=40;break}return t.next=37,n.v5o7v(s[f],c[s[f]]);case 37:f++,t.next=34;break;case 40:null,chrome.runtime.onMessage.addListener((function(t,e,r){var i=t.type,u=t.label;return b(v().mark((function t(){var c,s,l,f,h,p,m,b,g,x,L,E,O,I;return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:t.t0=i,t.next="FbpF"===t.t0?3:"Yap"===t.t0?30:"Be9D"===t.t0?36:"T149T"===t.t0?46:"relr"===t.t0?48:"ri9v"===t.t0?52:"Bm7F"===t.t0?70:"DojF"===t.t0?94:"F12lJ"===t.t0?96:102;break;case 3:if(1!==u.Kgaa){t.next=14;break}return(c=n.I62d(e.tab.id))||(c=d()),c[u.key]=u.value,c.updatedAt=Date.now(),t.next=12,n.U61a(e.tab.id,c);case 12:t.next=27;break;case 14:if(-1!==u.Kgaa){t.next=27;break}if(!u.RgbmR){t.next=25;break}return t.next=18,n.v5o7v(u.key,u.value);case 18:return t.next=20,chrome.storage.local.set(y({},u.key,u.value));case 20:if("__scope"!==u.key){t.next=23;break}return t.next=23,k();case 23:t.next=27;break;case 25:return t.next=27,n.U61a(u.key,u.value);case 27:return r({status:"success"}),t.abrupt("break",103);case 30:return s=void 0,1===u.Kgaa?(l=n.I62d(e.tab.id))&&(s=l[u.key]):-1===u.Kgaa?s=n.I62d(u.key):((h=n.I62d((null==e||null===(f=e.tab)||void 0===f?void 0:f.id)||"~"))&&(s=h[u.key]),s||(s=n.I62d(u.key))),r({status:"success",value:s?JSON.parse(JSON.stringify(s)):s}),t.abrupt("break",103);case 36:if(1!==u.Kgaa&&0!==u.Kgaa){t.next=41;break}return(p=n.I62d(e.tab.id))&&delete p[u.key],t.next=41,n.U61a(e.tab.id,p);case 41:if(-1!==u.Kgaa&&0!==u.Kgaa){t.next=44;break}return t.next=44,n.T699V(u.key);case 44:return r({status:"success"}),t.abrupt("break",103);case 46:return"Kho0"===u.name?a[u.hkId]=setInterval((function(){j(u.name,e,u.hkId)}),u.time):"_i1ct"===u.name?(clearInterval(a[u.hkId]),delete a[u.hkId]):"Ei3p"===u.name?a[u.hkId]=setTimeout((function(){j(u.name,e,u.hkId),delete a[u.hkId]}),u.time):"Li55L"===u.name&&(clearTimeout(a[u.hkId]),delete a[u.hkId]),t.abrupt("break",103);case 48:return t.next=50,w();case 50:return r({status:"success"}),t.abrupt("break",103);case 52:if(m=!1,n.I62d("__scope"),"01"!==x){t.next=59;break}m=!0,t.next=67;break;case 59:if("05"!==x&&"02"!==x){t.next=66;break}return t.next=62,chrome.tabs.query({active:!0});case 62:b=t.sent,m=(null==b?void 0:b.length)>0&&b.filter((function(t){return t.id===e.tab.id})).length>0,t.next=67;break;case 66:m=!1;case 67:return r({status:"success",value:m}),t.abrupt("break",103);case 70:if(g=!1,"01"!==(x=n.I62d("__scope"))){t.next=82;break}return t.next=76,chrome.tabs.query({active:!0});case 76:L=t.sent,E=(null==L?void 0:L.length)>0&&L.filter((function(t){return t.id===e.tab.id})).length>0,O=o.has(e.tab.id),g=!(!E&&!O),t.next=91;break;case 82:if("05"!==x&&"02"!==x){t.next=90;break}return t.next=85,chrome.tabs.query({active:!0});case 85:I=t.sent,g=(null==I?void 0:I.length)>0&&I.filter((function(t){return t.id===e.tab.id})).length>0,t.next=91;break;case 90:g=!1;case 91:return r({status:"success",value:g}),t.abrupt("break",103);case 94:return r({status:"success",value:e.frameId}),t.abrupt("break",103);case 96:return t.next=98,chrome.windows.update(e.tab.windowId,{focused:!0});case 98:return t.next=100,chrome.tabs.update(e.tab.id,{active:!0,muted:!0});case 100:return r({status:"success"}),t.abrupt("break",103);case 102:return t.abrupt("break",103);case 103:0;case 104:case"end":return t.stop()}}),t)})))(),!0})),chrome.runtime.onMessageExternal.addListener((function(t,e,r){b(v().mark((function a(){var i,u,c,s,l,f,h,p,y,b,g,w,x;return v().wrap((function(a){for(;;)switch(a.prev=a.next){case 0:if(u=e.id,!(c=n.I62d("J7ifL")).hasOwnProperty(u)){a.next=48;break}s=t.action,l=null,a.t0=s,a.next="CSL15je"===a.t0?9:"CSL15kp"===a.t0?13:"CSL15mo"===a.t0?32:47;break;case 9:return f=!1,null!=t&&null!==(i=t.data)&&void 0!==i&&i.tabId&&(h=n.I62d(t.data.tabId),f=!!h,"Whl7"===(null==h?void 0:h.uggp)&&(f=!1)),r({status:"success",data:{value:f}}),a.abrupt("break",48);case 13:if((l=c[u])&&l.connected){a.next=19;break}0,r({status:"fail",code:"0001",message:"not connected"}),a.next=30;break;case 19:if(null==t||null===(p=t.data)||void 0===p||!p.setting){a.next=29;break}return o.enqueue(t.data.tabId),(y=n.I62d(t.data.tabId))||(y=d(!0)),Object.keys(t.data.setting).forEach((function(e){y[e]=t.data.setting[e]?JSON.parse(JSON.stringify(t.data.setting[e])):t.data.setting[e]})),y.updatedAt=Date.now(),a.next=29,n.U61a(t.data.tabId,y);case 29:r({status:"success"});case 30:return a.abrupt("break",48);case 32:if(l=c[u],b=null,l&&l.connected){a.next=40;break}0,r({status:"fail",code:"0001",message:"not connected"}),a.next=46;break;case 40:return a.next=42,m(null==t||null===(g=t.data)||void 0===g?void 0:g.tabId,null==t||null===(w=t.data)||void 0===w?void 0:w.token);case 42:x=a.sent,b=x?["Whl7"].includes(x)?"success":["Qhb8","xhjgB"].includes(x)?"fail":"ing":"fail",r({status:"success",data:{value:b}});case 46:case 47:return a.abrupt("break",48);case 48:case"end":return a.stop()}}),a)})))()})),chrome.alarms.create("q5l",{when:Date.now()+5e3,periodInMinutes:1}),chrome.alarms.create("_96",{when:Date.now()+35e3,periodInMinutes:1}),chrome.alarms.onAlarm.addListener(function(){var t=b(v().mark((function t(e){return v().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(t.prev=0,!["q5l","_96"].includes(e.name)){t.next=5;break}return t.next=5,w();case 5:t.next=10;break;case 7:t.prev=7,t.t0=t.catch(0);case 10:case"end":return t.stop()}}),t,null,[[0,7]])})));return function(e){return t.apply(this,arguments)}}());case 46:case"end":return t.stop()}}),t)})))()}});