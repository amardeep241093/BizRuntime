function Employee(name) {
    this.Name = name;
}

Employee.prototype.GetName = function () {
    return this.Name;
}