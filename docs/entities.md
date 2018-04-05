---
layout: default
---
# Entities

>Entities encapsulate Enterprise wide business rules. An entity can be an object with methods, or it can be a set of data structures and functions. It doesn’t matter so long as the entities could be used by many different applications in the enterprise.
>
>If you don’t have an enterprise, and are just writing a single application, then these entities are the business objects of the application. They encapsulate the most general and high-level rules. They are the least likely to change when something external changes. For example, you would not expect these objects to be affected by a change to page navigation, or security. No operational change to any particular application should affect the entity layer.

* https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html *


>"My view of Entities is that they contain Application Independent Business rules.  They are not simply data objects.  They may hold references to data objects; but their purpose is to implement business rule methods that can be used by many different applications.
>
>Gateways return Entities.  The implementation (below the line) fetches the data from the database, and uses it to construct data structures which are then passed to the Entities.  This can be done either with containment or inheritance.
>
>For example:  
>
>public class MyEntity { private MyDataStructure data;}
>
>or
>
>public class MyEntity extends MyDataStructure {...}
>
>And remember, we are all pirates by nature; and the rules I'm talking about here are really more like guidelines..."

* https://groups.google.com/forum/#!topic/clean-code-discussion/mvP_NR2MUPc *

>Entities are completely invisible to the outside layers. Not any thing but the interactors know about them. Entities contain business logic, e.g., a Gopher entity can modify itself or contain functions related to it, but the distinction between entities and interactors is the following:
>
>entities modify themselves vs.
>interactors modify entities
>An entity can contain other entities: a Gopher, could technically possess a Tail and two Eyes, and it can modify them at will. This hierarchy is strictly unidirectional: a Gopher doesn’t know about other gophers, more importantly, it doesn’t know about the interactor.

* http://ebi.readthedocs.io/en/latest/core.html#entities *

[back](./)